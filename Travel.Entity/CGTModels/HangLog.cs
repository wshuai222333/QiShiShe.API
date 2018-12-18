using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class HangLog
    {
        public int Id { get; set; }
        public long? TradeId { get; set; }
        public string TradePassengerName { get; set; }
        public string TradeTicketNo { get; set; }
        public int? HangStatus { get; set; }
        public DateTime? HangTime { get; set; }
        public string HangOrder { get; set; }
        public Guid? TableId { get; set; }
        public string OrderId { get; set; }
        public string Operation { get; set; }
    }
}
