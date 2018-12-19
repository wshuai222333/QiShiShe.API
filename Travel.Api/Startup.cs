using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using QiShiShe.DDD.Utils.Http;

namespace QiShiShe.Api {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
        //注入Autofac容器
        public IContainer ApplicationContainer {
            get; private set;
        }
        public IConfiguration Configuration {get;}

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services) {
            //添加.net自带缓存
            services.AddMemoryCache();
            #region 注入获取HTTP上下文服务
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            #region 跨域
            var urls = Configuration["AppConfig:Cores"].Split(',');
            services.AddCors(options =>
            options.AddPolicy("AllowSameDomain",
                              builder => builder.WithOrigins(urls).AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin().AllowCredentials())
             );
            #endregion

            #region MVC修改控制器描述
            services.AddHttpContextAccessor();
            services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());
            services.AddMvc(config => {
                config.RespectBrowserAcceptHeader = true;
            })
            .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new ContractResolver())
            .AddJsonOptions(options => options.SerializerSettings.Converters.Add(new ChinaDateTimeConverter()))
            .AddFormatterMappings(options => options.SetMediaTypeMappingForFormat("xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"))
            .AddFormatterMappings(options => options.SetMediaTypeMappingForFormat("jpeg", "image/jpeg"))
            .AddFormatterMappings(options => options.SetMediaTypeMappingForFormat("jpg", "image/jpeg"));

            #endregion



            #region Autofac配置
            var autofac = new ContainerBuilder();
            var assembly = Assembly.Load(new AssemblyName("QiShiShe.Api.Controllers"));
            var manager = new ApplicationPartManager();

            manager.ApplicationParts.Add(new AssemblyPart(assembly));
            manager.FeatureProviders.Add(new ControllerFeatureProvider());

            var feature = new ControllerFeature();

            manager.PopulateFeature(feature);

            autofac.RegisterType<ApplicationPartManager>().AsSelf().SingleInstance();
            autofac.RegisterTypes(feature.Controllers.Select(ti => ti.AsType()).ToArray()).PropertiesAutowired();

            autofac.RegisterModule(new AutofacModule());
            autofac.Populate(services);
            ApplicationContainer = autofac.Build();
            #endregion

            #region AutoMapper
            //AutoMapperConfiguration.RegisterMappings();
            #endregion
            //设置支持gb2312
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            return new AutofacServiceProvider(ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IServiceProvider svp) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

#pragma warning disable CS0618 // Type or member is obsolete
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
#pragma warning restore CS0618 // Type or member is obsolete

            CGTHttpContext.ServiceProvider = svp;
            app.UseCors("AllowSameDomain");
            app.UseStaticFiles();
            app.UseStaticHttpContext();
            app.UseMvc();
        }
    }
}
