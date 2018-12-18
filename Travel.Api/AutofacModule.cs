using Autofac;
using System.Linq;
using System.Reflection;
using Travel.Api.DTO;

namespace Travel.Api {
    /// <summary>
    /// autofac注入类
    /// </summary>
    public class AutofacModule : Autofac.Module {
        /// <summary>
        /// 加载注入
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder) {
            //petapoco仓储注入
            //var petapocobase_repository = Assembly.Load(new AssemblyName("CGT.PetaPoco.Repositories"));
            //builder.RegisterAssemblyTypes(petapocobase_repository)
            //    .Where(t => t.Name.EndsWith("Rep"))
            //    .AsSelf()
            //    .PropertiesAutowired();

            ////mongodb仓储注入
            //var mongo_model = Assembly.Load(new AssemblyName("CGT.Entity"));
            //builder.RegisterAssemblyTypes(mongo_model)
            //    .Where(t => t.Name.EndsWith("MongoModel"))
            //    .AsSelf()
            //    .PropertiesAutowired();
            //builder.RegisterGeneric(typeof(MongoRepository<>)).As(typeof(IMongoRepository<>));

            //apiservice业务注入
            builder.RegisterType<ResponseMessageModel>()
                .AsSelf()
                .PropertiesAutowired();

            var apiservice = Assembly.Load(new AssemblyName("Travel.Api.Service"));
            builder.RegisterAssemblyTypes(apiservice)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .AsSelf()
                .PropertiesAutowired();

            ////注入Execl
            //builder.RegisterType<ExeclHelper>()
            //    .AsSelf()
            //    .PropertiesAutowired();


            //apiservice业务注入
            builder.RegisterType<ResponseMessageModel>()
                .AsSelf()
                .PropertiesAutowired();

            //CGT.CheckTicket.Service 业务注入
            var checkticketservice = Assembly.Load(new AssemblyName("TravelCheckTicketForA.Service"));
            builder.RegisterAssemblyTypes(checkticketservice)
                .Where(t => t.Name.EndsWith("Processor"))
                .AsImplementedInterfaces()
                .AsSelf()
                .PropertiesAutowired();
        }
    }
}
