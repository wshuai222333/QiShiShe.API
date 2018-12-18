using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TradeCreditPayDetail
    {
        public long CreditPayDetailId { get; set; }
        public decimal PayMoney { get; set; }
        public long TradeId { get; set; }
        public int Status { get; set; }
        public string OrderId { get; set; }
        public long UserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? TableId { get; set; }
    }
}
