using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TradeTopUp
    {
        public long TradeTopUpId { get; set; }
        public long? FromUserId { get; set; }
        public long? ToUserId { get; set; }
        public long? TradeId { get; set; }
        public decimal? Amount { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? SuccessTime { get; set; }
        public Guid? TableId { get; set; }
        public string InTradeNo { get; set; }
        public string OutTradeNo { get; set; }
    }
}
