using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class BindCard
    {
        public long BindCardId { get; set; }
        public long? UserId { get; set; }
        public string BankNumber { get; set; }
        public string BankOpenName { get; set; }
        public string BankName { get; set; }
        public string CenterBank { get; set; }
        public string BranchBank { get; set; }
        public int? BankCardType { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int? CertificateType { get; set; }
        public string CertificateNumber { get; set; }
        public string UserAgreementNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? TableId { get; set; }
    }
}
