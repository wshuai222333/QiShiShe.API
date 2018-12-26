namespace QiShiShe.Api.DTO.Boss.Request.Department {
    public class RequestUpdateDepartment : RequestOriBaseModel {
        public string DepartmentName { get; set; }

        public int EnterpriseId { get; set; }

        public int DepartmentId { get; set; }
    }
}
