using System;
using QiShiShe.DDD.Domain;

namespace QiShiShe.Entity.CGTModels {
    public partial class InterfaceAccount: EntityBase {
        public int Id { get; set; }
        public string MerchantName { get; set; }
        public string MerchantIp { get; set; }
        public string MerchantCode { get; set; }
        public string ReapayMerchantNo { get; set; }
        public int? Status { get; set; }
        public string UserKey { get; set; }
        public string CertAddress { get; set; }
        public string CertPassword { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ReapalMerchantId { get; set; }
        public int? UserType { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserId { get; set; }
        public Guid? TableId { get; set; }
        public string SuspendedServiceUrl { get; set; }
        public string MerchantPwd { get; set; }
        public string ReapalUserKey { get; set; }
        public int? IsCheckPrice { get; set; }
    }
}
