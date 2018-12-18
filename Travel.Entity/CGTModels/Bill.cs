using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class Bill
    {
        public long BillId { get; set; }
        public decimal BillAmount { get; set; }
        public decimal RepayAmount { get; set; }
        public decimal RefundAmount { get; set; }
        public DateTime BillDate { get; set; }
        public int RepayStatus { get; set; }
        public int SettlementStatus { get; set; }
        public DateTime? CreateTime { get; set; }
        public int BillStartToEndDate { get; set; }
        public long UserId { get; set; }
        public int SumPassengerNum { get; set; }
        public decimal? TodayBillAmount { get; set; }
        public decimal? BalanceBillAmount { get; set; }
        public int? BillType { get; set; }
        public Guid? TableId { get; set; }
        public int? RepayType { get; set; }
        public decimal? BalanceBillFree { get; set; }
        public decimal? BalanceBillFreeAmount { get; set; }
        public decimal? AllBalanceBillFreeAmount { get; set; }
        public decimal? BalanceBillRefundAmount { get; set; }
        public decimal? BillInterest { get; set; }
        public decimal? AllBillInterest { get; set; }
        public decimal? LastBalanceBillAmount { get; set; }
    }
}
