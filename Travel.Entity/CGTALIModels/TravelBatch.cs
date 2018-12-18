using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTALIModels
{
    public partial class TravelBatch
    {
        public long TravelBatchResultId { get; set; }
        public string TravelBatchId { get; set; }
        public string PayCenterCode { get; set; }
        public string PayCenterName { get; set; }
        public int? EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? TotalCount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? Status { get; set; }
    }
}
