using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request {
    public class RequestBackgroundUserLogin:RequestOriBaseModel {
        public string UserName { get; set; }

        public string UserPwd { get; set; }
    }
}
 