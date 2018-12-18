using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class UserAutoRefund
    {
        public long UserAutoRefundId { get; set; }
        public long? UserId { get; set; }
        public int? Stauts { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserId { get; set; }
        public Guid? TableId { get; set; }
    }
}
