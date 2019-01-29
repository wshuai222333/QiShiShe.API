using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Enterprise.Request.Order {
    public class GetDemandOrderList : RequestOriBaseModel {
        public int pageindex { get; set; }

        public int pagesize { get; set; }

        public int EnterpriseId { get; set; }
    }
}
