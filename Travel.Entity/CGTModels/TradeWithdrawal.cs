using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TradeWithdrawal
    {
        public long WithdrawalId { get; set; }
        public long UserId { get; set; }
        public string ReapalBindId { get; set; }
        public string InTradeNo { get; set; }
        public string OutTradeNo { get; set; }
        public int Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? SuccessTime { get; set; }
    }
}
