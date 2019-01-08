using System;

namespace QiShiShe.Api.DTO.Boss.Request.Staff {
    public class RequestAddStaff : RequestOriBaseModel {
        public int EnterpriseId { get; set; }

        public string StaffName { get; set; }

        public string StaffCardNo { get; set; }

        public DateTime? StaffBirthday { get; set; }

        public int DepartmentId { get; set; }

        public int StaffId { get; set; }

        public string EnterpriseName { get; set; }

        public string Phone { get; set; }
    }
}
