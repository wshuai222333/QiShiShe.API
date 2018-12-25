using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request {
    public class RequestUpdateBackgroundUser : RequestOriBaseModel {

        public int BackgroundUserId { get; set; }

        public string UserName { get; set; }

        public string UserPwd { get; set; }

        public string RealName { get; set; }
    }
}
