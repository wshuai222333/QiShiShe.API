using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TradeSegment
    {
        public long? TradeId { get; set; }
        public long TradeSegmentId { get; set; }
        public string Airline { get; set; }
        public string FlightNo { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string Cabin { get; set; }
        public Guid? TableId { get; set; }
        public string PlatformOrderId { get; set; }
    }
}
