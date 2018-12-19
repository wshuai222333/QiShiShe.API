using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTLOGModels
{
    public partial class UserLog
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public DateTime? LoginTime { get; set; }
        public string LoginIp { get; set; }
        public string PerformMethod { get; set; }
        public string PerformContent { get; set; }
        public string PerformResult { get; set; }
        public int? Status { get; set; }
    }
}
