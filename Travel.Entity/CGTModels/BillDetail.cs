using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class BillDetail
    {
        public long BillDetailId { get; set; }
        public long? BillId { get; set; }
        public string OrderId { get; set; }
        public decimal? OrderTotalAmout { get; set; }
        public decimal FreezeAmount { get; set; }
        public decimal ShouldRepayAmount { get; set; }
        public decimal RepayAmount { get; set; }
        public int RepayStatus { get; set; }
        public DateTime BillDate { get; set; }
        public long UserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? Isrefundment { get; set; }
        public string PlatformName { get; set; }
        public int? PlatformCode { get; set; }
        public Guid? TableId { get; set; }
        public int? AuthStatus { get; set; }
        public decimal? OrderInterest { get; set; }
        public string GoldMasterName { get; set; }
        public int? OrderSource { get; set; }
        public int? OrderType { get; set; }
    }
}
