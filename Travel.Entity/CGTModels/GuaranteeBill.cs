using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class GuaranteeBill
    {
        public long GuaranteeBillId { get; set; }
        public long BillId { get; set; }
        public int? Status { get; set; }
        public long GuaranteeUserId { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string GuaranteeUserName { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? GuaranteeCount { get; set; }
        public DateTime? GuaranteeDate { get; set; }
        public int? GuaranteeHour { get; set; }
    }
}
