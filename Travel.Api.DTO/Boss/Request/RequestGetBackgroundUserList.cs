using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request {
    public class RequestGetBackgroundUserList : RequestOriBaseModel {
        public int pageindex { get; set; }

        public int pagesize { get; set; }
    }
}
