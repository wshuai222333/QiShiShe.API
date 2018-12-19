using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTLOGModels
{
    public partial class BillLog
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public long? BillId { get; set; }
        public decimal? RepayAmount { get; set; }
        public decimal? BillAmount { get; set; }
        public DateTime? BillDate { get; set; }
        public int? RepayStatus { get; set; }
        public int? SettlementStatus { get; set; }
        public string PerformMethod { get; set; }
        public string PerformContent { get; set; }
        public string PerformResult { get; set; }
        public DateTime? BillTime { get; set; }
        public int? Status { get; set; }
    }
}
