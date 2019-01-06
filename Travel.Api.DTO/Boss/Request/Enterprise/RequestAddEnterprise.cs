namespace QiShiShe.Api.DTO.Boss.Request {
    public class RequestAddEnterprise : RequestOriBaseModel {

        public string EnterpriseName { get; set; }

        public string EnterpriseCode { get; set; }

        public string ContactsName { get; set; }

        public string ContactsPhone { get; set; }
        public string ContactsEmail { get; set; }

        public int EnterpriseId { get; set; }
    }
}
