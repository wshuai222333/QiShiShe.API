using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request.Enterprise {
    public class RequestUpdateEnterprise : RequestOriBaseModel {
        public string EnterpriseName { get; set; }

        public string EnterpriseCode { get; set; }

        public string ContactsName { get; set; }

        public string ContactsPhone { get; set; }
        public string ContactsEmail { get; set; }
    }
}
