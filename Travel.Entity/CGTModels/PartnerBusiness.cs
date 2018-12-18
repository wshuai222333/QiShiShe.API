using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class PartnerBusiness
    {
        public long PartnerBusinessId { get; set; }
        public string BusinessType { get; set; }
        public string BusinessName { get; set; }
        public string BusinessRemark { get; set; }
        public string BusinessCode { get; set; }
        public int? Status { get; set; }
    }
}
