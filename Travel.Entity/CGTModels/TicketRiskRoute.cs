using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TicketRiskRoute
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? OperationUserId { get; set; }
    }
}
