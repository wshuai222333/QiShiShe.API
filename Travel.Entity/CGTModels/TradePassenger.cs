using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TradePassenger
    {
        public long? TradeId { get; set; }
        public long TradePassengerId { get; set; }
        public string PassengerName { get; set; }
        public int? PassengerType { get; set; }
        public int? PsgIndexInPnr { get; set; }
        public int? CardType { get; set; }
        public string CardNo { get; set; }
        public DateTime? Birthday { get; set; }
        public string AirTicketNo { get; set; }
        public int? TiketNoHangStatus { get; set; }
        public string PlatformOrderId { get; set; }
        public Guid? TableId { get; set; }
        public int? TicketType { get; set; }
        public string OfficeNo { get; set; }
    }
}
