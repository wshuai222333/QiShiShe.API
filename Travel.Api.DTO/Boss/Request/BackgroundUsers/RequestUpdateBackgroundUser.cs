using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request {
    public class RequestUpdateBackgroundUser : RequestOriBaseModel {

        public int BackgroundUserId { get; set; }

       public int Status { get; set; }
    }
}
