using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TicketPolicyRule
    {
        public long Id { get; set; }
        public string AirCode { get; set; }
        public string CabinDesc { get; set; }
        public string Cabin { get; set; }
        public string Discount { get; set; }
        public bool? VoluntaryTicketPolicy { get; set; }
        public string Remark { get; set; }
        public DateTime? ReleaseDateTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
