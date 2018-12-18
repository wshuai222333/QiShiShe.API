
using Newtonsoft.Json;
using System;
using Travel.DDD.Logger;
using Travel.DDD.SOA;
using Travel.DDD.Utils.Http;

namespace TravelCheckTicketForA.Service {
    public abstract class ProcessorBase<TResponse, TResult> {
        //设置请求参数数据格式
        private const string RequestEncodingName = "UTF-8";
        private const string ParameterEncodingName = "UTF-8";

        /// <summary>
        /// 接口名称
        /// </summary>
        protected abstract string RequestAddress {
            get;
        }
        /// <summary>
        /// 接口地址
        /// </summary>
        protected abstract string ServiceAddress {
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual bool IsBase {
            get {
                return true;
            }
        }

        /// <summary>
        /// 请求参数
        /// </summary>
        /// <returns></returns>
        protected abstract string PrepareRequestCore();
        protected virtual TResult ParseResponseCore(TResponse response) {
            throw new InvalidOperationException();
        }
        /// <summary>
        /// 执行调用api验票
        /// </summary>
        /// <returns></returns>
        /// 
        public ExecResult<TResult> Execute() {
            var result = new ExecResult<TResult>();
            var target = string.Empty;
            var request = string.Empty;
            var response = string.Empty;
            DateTime? reqTime = null;
            DateTime? resTime = null;
            try {
                target = GetRequestUrl();
                request = PrepareRequest();

                reqTime = DateTime.Now;
                response = HttpRequest.HttpRequestUtility.SendPostRequest(target, request, RequestEncodingName, 30000);
                resTime = DateTime.Now;

                if (IsBase) {
                    result = ParseResponse(response);
                }
            } catch (Exception ex) {
                LoggerFactory.Instance.Logger_Error(ex, "CheckTicketForAService");
                result = new ExecResult<TResult> {
                    Success = false,
                    Message = ex.Message
                };
            }

            if (reqTime.HasValue) {
                LoggerFactory.Instance.Logger_Info(
                    string.Format("CheckTicketForAService----target:{1}{0}reqTime:{2:yyyy-MM-dd HH:mm:ss.fff}{0}request:{3}{0}resTime:{4:yyyy-MM-dd HH:mm:ss.fff}{0}response:{5}{0}",
                        Environment.NewLine, target, reqTime, request, resTime, response), "CheckTicketForAService");
            }
            return result;
        }

        /// <summary>
        /// 返回信息验票
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private ExecResult<TResult> ParseResponse(string response) {
            var result = new ExecResult<TResult>();
            var view = JsonConvert.DeserializeObject<CheckTicketResponseView>(response);

            if (typeof(TResponse) == typeof(TResult)) {
                if (view.IsSuccess && view.Message.Contains("旅客姓名")) {
                    result.Success = true;
                    result.Message = view.Message;
                    result.MsgCode = "0000";


                  
                } else {
                    result.Success = false;
                    result.Message = view.Message;
                    result.MsgCode = "0001";

                  
                }

            } else {
                //result.Result = ParseResponseCore(JsonConvert.DeserializeObject<TResponse>(view));
            }
            return result;
        }


        #region 方法
        /// <summary>
        /// 获取请求url
        /// </summary>
        /// <returns></returns>
        private string GetRequestUrl() {
            return ServiceAddress + "/" + RequestAddress;
        }
        private string PrepareRequest() {
            var parameters = PrepareRequestCore();
            return parameters;
        }
        #endregion
    }
    public abstract class ProcessorBase<T> : ProcessorBase<T, T> {
    }
}
