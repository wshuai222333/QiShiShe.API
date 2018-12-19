using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TicketRiskRefund
    {
        public int Id { get; set; }
        public long? TradeId { get; set; }
        public string OrderId { get; set; }
        public string Passengers { get; set; }
        public DateTime? StartDate { get; set; }
        public string Airline { get; set; }
        public string Cabin { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal? Amount { get; set; }
        public string PlatformOrderId { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? BillId { get; set; }
        public long? UserId { get; set; }
        public decimal? RefundAmout { get; set; }
        public int? RefundStatus { get; set; }
        public Guid? TableId { get; set; }
    }
}
