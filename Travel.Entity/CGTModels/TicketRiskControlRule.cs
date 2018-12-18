using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TicketRiskControlRule
    {
        public int Id { get; set; }
        public string MerchantCode { get; set; }
        public string MerchantName { get; set; }
        public int? RuleType { get; set; }
        public int? RuleSort { get; set; }
        public string Day { get; set; }
        public string Proportion { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? ModifyUser { get; set; }
        public Guid? TableId { get; set; }
    }
}
