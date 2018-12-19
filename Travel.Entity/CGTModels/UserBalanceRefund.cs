using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class UserBalanceRefund
    {
        public long UserBalanceRefundId { get; set; }
        public long UserId { get; set; }
        public int Stauts { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserId { get; set; }
    }
}
