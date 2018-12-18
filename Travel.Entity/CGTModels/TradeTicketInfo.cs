using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TradeTicketInfo
    {
        public long TradeInfoId { get; set; }
        public long TradeId { get; set; }
        public long UserId { get; set; }
        public string UserPwd { get; set; }
        public int UserType { get; set; }
        public string OrderId { get; set; }
        public decimal OrderPrice { get; set; }
        public string PlatformOrderId { get; set; }
        public string PlatformName { get; set; }
        public int PlatformCode { get; set; }
        public string PlatformLoginPwd { get; set; }
        public string PartnerCode { get; set; }
        public int IsAllPayMoney { get; set; }
        public string NumberRefund { get; set; }
        public decimal TicketPrice { get; set; }
        public decimal PayPrice { get; set; }
        public decimal RebatePrice { get; set; }
        public decimal? Rebate { get; set; }
        public string Pnr { get; set; }
        public string PayUrl { get; set; }
        public string NotifyUrl { get; set; }
        public string Ip { get; set; }
        public int TimesTamp { get; set; }
        public DateTime? CreateTime { get; set; }
        public int PassengerNum { get; set; }
        public DateTime StartDate { get; set; }
        public string ChannelOrderId { get; set; }
        public string ChannelUrl { get; set; }
        public decimal? NumberRefundRebate { get; set; }
        public string ReturnUrl { get; set; }
        public Guid? TableId { get; set; }
        public decimal? PlatFee { get; set; }
        public decimal? Agio { get; set; }
        public decimal? Tax { get; set; }
    }
}
