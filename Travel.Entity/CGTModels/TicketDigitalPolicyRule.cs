using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TicketDigitalPolicyRule
    {
        public long Id { get; set; }
        public long TicketPolicyRuleId { get; set; }
        public string AirCode { get; set; }
        public string Cabin { get; set; }
        public string RefundTicketRule { get; set; }
        public string ChangeTicketRule { get; set; }
        public Guid? TableId { get; set; }
    }
}
