using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Enterprise.Request.Staff {
    public class RequestGetStaffList : RequestOriBaseModel {
        public int EnterpriseId { get; set; }

        public string StaffName { get; set; }

        public string StaffCardNo { get; set; }

        public string Phone { get; set; }
    }
}
