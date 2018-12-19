using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TradeNotify
    {
        public long TradeNotifyId { get; set; }
        public string OrderId { get; set; }
        public string Notify { get; set; }
        public int NotifyNum { get; set; }
        public DateTime PerformTime { get; set; }
        public string PerformData { get; set; }
        public DateTime? SuccessTime { get; set; }
        public int Status { get; set; }
    }
}
