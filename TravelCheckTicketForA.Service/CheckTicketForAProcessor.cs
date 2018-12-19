using Newtonsoft.Json;
using System;
using QiShiShe.DDD;
using QiShiShe.DDD.Config;

namespace TravelCheckTicketForA.Service {
    public class CheckTicketForAProcessor : ProcessorBase<CheckTicketResponseView> {

        protected override string RequestAddress {
            get {
                return "Detr/DetrS";
            }
        }

        protected override string ServiceAddress {
            get {
                return JsonConfig.JsonRead("CheckTicketForAApiUrl", "CheckTicketForA");
            }
        }
        private  string _param;
        private  string _key;
        private  string _sign;

        public void Init(CheckTicketRequestView param) {
            param.CompanyId = Convert.ToInt32(JsonConfig.JsonRead("CheckTicketForACompanyId", "CheckTicketForA"));
            param.RequestTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            _param = JsonConvert.SerializeObject(param);
            _key = JsonConfig.JsonRead("CheckTicketForAKey", "CheckTicketForA");
            _sign = Encrpty.MD5Encrypt(_param + _key).ToUpper();
        }
        protected override string PrepareRequestCore() {
            string result = "param=" + _param + "&" + "sign=" + _sign;
            return result;
        }
    }
}
