using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TicketScanInfo
    {
        public int Id { get; set; }
        public string MerchantCode { get; set; }
        public string BackUserName { get; set; }
        public string BackMerchantCode { get; set; }
        public int? IsSuspend { get; set; }
        public string TicketNo { get; set; }
        public string OrderId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string MerchantName { get; set; }
        public string DepartureTime { get; set; }
        public string FlightNo { get; set; }
        public string Airline { get; set; }
        public int? TicketType { get; set; }
        public string PassengerName { get; set; }
        public int? ScanStatus { get; set; }
        public DateTime? ScanTime { get; set; }
        public int? RechargeStatus { get; set; }
        public Guid? TableId { get; set; }
    }
}
