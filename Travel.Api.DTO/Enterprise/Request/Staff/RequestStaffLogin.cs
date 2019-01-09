namespace QiShiShe.Api.DTO.Enterprise.Request.Staff {
    public class RequestStaffLogin : RequestOriBaseModel {
        public string UserName { get; set; }

        public string UserPwd { get; set; }
    }
}
