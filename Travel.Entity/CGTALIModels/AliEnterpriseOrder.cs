using System;
using QiShiShe.DDD.Domain;

namespace QiShiShe.Entity.CGTALIModels {
    public partial class AliEnterpriseOrder : EntityBase {
        public int AliEnterpriseOrderId { get; set; }
        public string OrderId { get; set; }
        public string TicketNo { get; set; }
        public string PassengerName { get; set; }
        public DateTime? DepartureTime { get; set; }
        public string DepartureCity { get; set; }
        public string ReachCity { get; set; }
        public string Pnr { get; set; }
        public decimal? TicketAmount { get; set; }
        public string Airline { get; set; }
        public string FlightNo { get; set; }
        public string PassengerNo { get; set; }
        public int? BackStatus { get; set; }
        public DateTime? BackTime { get; set; }
        public string BackMessage { get; set; }
        public DateTime? CreateTime { get; set; }
        public string PayCenterCode { get; set; }
        public string PayCenterName { get; set; }
        public int? EnterpriseWhiteListId { get; set; }
        public DateTime? TicketTime { get; set; }
        public string OrderTravelBatchId { get; set; }
        public string OrderEnterpriseName { get; set; }
        public int? Airway { get; set; }
        public int? OrderType { get; set; }
        public int? SubmitStatus { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string SubmitMessage { get; set; }
    }
}
