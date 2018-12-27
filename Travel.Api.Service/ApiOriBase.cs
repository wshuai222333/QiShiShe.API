
using Newtonsoft.Json;
using QiShiShe.Api.DTO;
using QiShiShe.DDD;
using QiShiShe.DDD.Logger;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace QiShiShe.Api.Service {
    public abstract class ApiOriBase<P> : ApiBaseBase<P>
        where P : RequestOriBaseModel, new() {
        //初始化异步锁
        private static SemaphoreSlim _mutex = new SemaphoreSlim(5);

        protected ApiOriBase() {
        }
        /// <summary>
        /// 用户信息仓储
        /// </summary>
        //public AgentRep agentRep { get; set; }

        //public Agent agent { get; set; }
        /// <summary>
        /// 返回实体
        /// </summary>
        public ResponseMessageModel Result { get; set; }

        public P Parameter { get; set; }

        protected abstract void ExecuteMethod();

        public override ResponseMessageModel Execute(P t) {
            _mutex.Wait();
            try {
                Parameter = t;
                Validate();
                ExecuteMethod();
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
            //异步锁释放
            _mutex.Release();
            return Result;
        }

        /// <summary>
        /// 验证
        /// </summary>
        protected void Validate() {

            //var agentmodel = new Agent() { AgentId = int.Parse(this.Parameter.AgentId) };

            //agent = agentRep.GetAgent(agentmodel);

            //验证商户是否存在
            //if (agent == null) {
            //    throw new MerchantException();
            //}
            //验证sign
            var userKey = "823C2561D42946B98CE8652614C43FED";
            if (!this.Parameter.Sign.Equals(GetMySign(userKey))) {
                //LoggerFactory.Instance.Logger_Debug(GetMySignStr(agent.UserKey)+"|"+ GetMySign(agent.UserKey)+"|"+ this.Parameter.Sign, "SignError");
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
            string MySign = Encrpty.MD5Encrypt(string.Format(@"AgentId={0}&TimesTamp={1}&Ip={2}&Mac={3}{4}"
                        , this.Parameter.AgentId
                        , this.Parameter.TimesTamp
                        , this.Parameter.Ip
                        , this.Parameter.Mac
                        , userkey));
            return MySign;
        }
        private string GetMySignStr(string userkey) {
            return string.Format(@"AgentId={0}&TimesTamp={1}&Ip={2}&Mac={3}{4}"
                        , this.Parameter.AgentId
                        , this.Parameter.TimesTamp
                        , this.Parameter.Ip
                        , this.Parameter.Mac
                        , userkey);
        }
    }
}
