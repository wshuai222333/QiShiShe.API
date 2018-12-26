namespace QiShiShe.Api.DTO.Boss.Request.Department {
    public class RequestGetDepartmentList : RequestOriBaseModel {
        public int pageindex { get; set; }

        public int pagesize { get; set; }

        public int EnterpriseId { get; set; }
    }
}
