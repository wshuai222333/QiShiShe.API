using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TicketRiskCabin
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public string Cabin { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? OperationUserId { get; set; }
    }
}
