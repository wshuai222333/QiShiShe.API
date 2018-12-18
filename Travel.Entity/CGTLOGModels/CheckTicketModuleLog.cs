using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTLOGModels
{
    public partial class CheckTicketModuleLog
    {
        public long Id { get; set; }
        public string TravelBatchId { get; set; }
        public string MerchantCode { get; set; }
        public string PayCenterCode { get; set; }
        public int? EnterpriseId { get; set; }
        public int? TicketNum { get; set; }
        public int? CheckRule { get; set; }
        public int? FristRule { get; set; }
        public int? SecondRule { get; set; }
        public int? ThirdRule { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? TimeDifference { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
