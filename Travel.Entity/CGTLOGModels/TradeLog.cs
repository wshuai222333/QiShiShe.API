using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTLOGModels
{
    public partial class TradeLog
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? TradeId { get; set; }
        public string UserName { get; set; }
        public string InTradeNo { get; set; }
        public string OutTradeNo { get; set; }
        public string PerformMethod { get; set; }
        public string PerformContent { get; set; }
        public string PerformResult { get; set; }
        public DateTime? TradeTime { get; set; }
        public int? Status { get; set; }
    }
}
