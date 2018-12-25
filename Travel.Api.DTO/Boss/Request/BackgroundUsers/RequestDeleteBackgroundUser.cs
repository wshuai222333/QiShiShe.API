using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request.BackgroundUsers {
    public class RequestDeleteBackgroundUser : RequestOriBaseModel {
        public int BackgroundUserId { get; set; }
    }
}
