using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TicketOrderRefound
    {
        public long RefoundId { get; set; }
        public long TradeId { get; set; }
        public string OrderId { get; set; }
        public string PayTradeNo { get; set; }
        public decimal RefoundMoney { get; set; }
        public int Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Name { get; set; }
        public string SuccessPnr { get; set; }
        public string ApplyPnr { get; set; }
    }
}
