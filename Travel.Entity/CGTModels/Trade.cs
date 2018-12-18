using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class Trade
    {
        public long TradeId { get; set; }
        public long UserId { get; set; }
        public string OrderId { get; set; }
        public long? BillId { get; set; }
        public DateTime? BillDate { get; set; }
        public string InTradeNo { get; set; }
        public string OutTradeNo { get; set; }
        public int TradeType { get; set; }
        public bool PayType { get; set; }
        public int? OrderPayType { get; set; }
        public decimal TradeSumMoney { get; set; }
        public decimal UserPayMoney { get; set; }
        public decimal? CreditPayMoney { get; set; }
        public int TradeStatus { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? SuccessTime { get; set; }
        public string ReapalOutTradeNo { get; set; }
        public int? BackStatus { get; set; }
        public Guid? TableId { get; set; }
        public string PayUserName { get; set; }
        public int? IsRemoney { get; set; }
        public int? Isuspended { get; set; }
        public int? SuspendedStatus { get; set; }
        public decimal? Poundage { get; set; }
        public int? SupendedSet { get; set; }
        public int? UnsupendedSet { get; set; }
        public decimal? SolutionRate { get; set; }
        public int? OutOrderPayType { get; set; }
        public decimal? RefundAmout { get; set; }
        public decimal? InterestRate { get; set; }
        public int? EnterpriseWhiteListId { get; set; }
        public string GoldMasterName { get; set; }
        public string RedTradeNo { get; set; }
        public int? TravelType { get; set; }
        public int? GoldMasterType { get; set; }
        public int? IsBill { get; set; }
        public int? TradeSource { get; set; }
    }
}
