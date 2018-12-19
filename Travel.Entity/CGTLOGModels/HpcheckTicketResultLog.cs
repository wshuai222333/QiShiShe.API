using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTLOGModels
{
    public partial class HpcheckTicketResultLog
    {
        public long Id { get; set; }
        public string TicketNo { get; set; }
        public int? CheckStatus { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
