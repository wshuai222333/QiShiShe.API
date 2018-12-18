using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class BillRepayLog
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public decimal? RepayAmount { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateTimeUserId { get; set; }
    }
}
