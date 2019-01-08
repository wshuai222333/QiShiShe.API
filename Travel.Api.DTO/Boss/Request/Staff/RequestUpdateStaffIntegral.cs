using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request.Staff {
    public class RequestUpdateStaffIntegral : RequestOriBaseModel {
        public int StaffId { get; set; }

        public int Integral { get; set; }
    }
}
