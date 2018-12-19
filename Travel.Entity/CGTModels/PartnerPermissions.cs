using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class PartnerPermissions
    {
        public long PartnerPermissionsId { get; set; }
        public string PartnerCode { get; set; }
        public long PartnerBusinessId { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateUserId { get; set; }
        public int? Status { get; set; }
    }
}
