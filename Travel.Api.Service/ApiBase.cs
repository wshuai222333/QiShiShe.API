
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using Travel.Api.DTO;
using Travel.DDD;
using Travel.DDD.Logger;

namespace Travel.Api.Service {
    /// <summary>
    /// api统一抽象基类
    /// </summary> 
    /// <typeparam name="P"></typeparam>
    public abstract class ApiBase<P> : ApiBaseBase<RequestModel>
        where P : RequestBaseModel, new() {
        //初始化异步锁
        //private static SemaphoreSlim _mutex = new SemaphoreSlim(5);
        /// <summary>
        /// 构造方法
        /// </summary>
        public ApiBase() {
            //EventBus.Instance.Subscribe<AddMongoLoggerEvent>(new AddMongoLoggerHandler());
        }

        #region 注入服务





        /// <summary>
        /// 返回实体
        /// </summary>
        public ResponseMessageModel Result {
            get; set;
        }
        #endregion

        /// <summary>
        /// 请求实体
        /// </summary>
        public RequestModel model {
            get; set;
        }

        /// <summary>
        /// 提交业务参数
        /// 
        /// </summary>
        public P Parameter {
            get; set;
        }

        /// <summary>
        /// 业务实现方法
        /// </summary>
        protected abstract void ExecuteMethod();

        /// <summary>
        /// 验证
        /// </summary>
        protected void Validate() {
            //var _interfaceAccount = interfaceAccountRep.GetInterfaceAccount(new InterfaceAccount() { MerchantCode = model.MerchantId });
            var _interfaceAccount = interfaceAccount.GetModel(i => i.MerchantCode == model.MerchantId).FirstOrDefault();
            if (_interfaceAccount == null) {
                throw new MerchantException("MerchantCode");
            }
            var aesAddress = _interfaceAccount.CertAddress.Split('|')[1];
            if (PlatformID.Win32NT != Environment.OSVersion.Platform) {
                //aesAddress = "/home/dev/" + aesAddress.Substring(3).Replace('\\', '/');
                aesAddress = "/app/CGT.Api/" + aesAddress.Substring(15).Replace('\\', '/');

            }
            //解密data
            var json = Encrpty.AESDecrypt(model.Data, Encrpty.RSADecrypt(model.EncryptKey, aesAddress, _interfaceAccount.CertPassword));
            // 反序列化Json为参数对象
            this.Parameter = JsonConvert.DeserializeObject<P>(json);
            //验证sign
            if (!this.Parameter.Sign.Equals(GetMySign(_interfaceAccount.UserKey))) {
                throw new ApiSignException("Sign");
            }
            //验证数据 
            if (!this.Parameter.IsValid) {
                throw new ValidationException("IsValid", this.Parameter.GetRuleViolationMessages());
            }
        }

        /// <summary>
        /// 获取MySign
        /// </summary>
        private string GetMySign(string userkey) {
            //MySign =(MerchantId = 12345 & TimesTamp = 2017 - 01 - 25 10:21:49 & Ip=167.0.12.31 & MAC = aaaa)+UserKey的值
            string MySign = Encrpty.MD5Encrypt(string.Format(@"MerchantId={0}&TimesTamp={1}&Ip={2}&Mac={3}{4}"
                        , model.MerchantId
                        , this.Parameter.TimesTamp
                        , this.Parameter.Ip
                        , this.Parameter.Mac
                        , userkey));

            return MySign;
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <returns></returns>
        public override ResponseMessageModel Execute(RequestModel json) {
            //异步锁等待
            //_mutex.Wait();
            try {
                //实体赋值
                model = json;
                //执行验证
                if (model != null) {
                    this.Validate();
                }
                //执行业务方法
                this.ExecuteMethod();
            } catch (Exception ex) {
                #region 异常处理
                this.Result.Data = null;
                this.Result.ErrorCode = "9999";
                this.Result.Message = ex.Message;
                this.Result.IsSuccess = false;
                //日志记录
                StringBuilder DebugeInfo = new StringBuilder();
                DebugeInfo.Append("Parameter:" + JsonConvert.SerializeObject(this.Parameter) + "\r\n");
                DebugeInfo.Append("Exception:" + ex.Message + "|" + ex.StackTrace + "\r\n");
                LoggerFactory.Instance.Logger_Debug(DebugeInfo.ToString(), "ExecuteMethodError");
                #endregion
            }
            this.Result.MerchantId = model.MerchantId;
            //异步锁释放
            //_mutex.Release();
            return Result;
        }
    }
}
