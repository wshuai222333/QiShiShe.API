namespace QiShiShe.Api.DTO.Boss.Request.Staff {
    public class RequestGetStaffList : RequestOriBaseModel {
        public int pageindex { get; set; }

        public int pagesize { get; set; }

        public int EnterpriseId { get; set; }

        public string StaffName { get; set; }

        public string StaffCardNo { get; set; }
    }
}
