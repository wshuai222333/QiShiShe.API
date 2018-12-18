using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TicketPolicyRuleDetail
    {
        public long Id { get; set; }
        public long TicketPolicyRuleId { get; set; }
        public int? StartHour { get; set; }
        public int? EndHour { get; set; }
        public string StartHourDesc { get; set; }
        public string EndHourDesc { get; set; }
        public string StartDesc { get; set; }
        public string EndDesc { get; set; }
        public int? RuleType { get; set; }
    }
}
