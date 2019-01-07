using System;

namespace QiShiShe.Api.DTO.Boss.Request.Staff {
    public class RequestUpdateStaff : RequestOriBaseModel {
        public string StaffName { get; set; }

        public string StaffCardNo { get; set; }

        public DateTime? StaffBirthday { get; set; }

        public int DepartmentId { get; set; }
    }
}
