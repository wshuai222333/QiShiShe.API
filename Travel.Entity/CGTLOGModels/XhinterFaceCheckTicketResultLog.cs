using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTLOGModels
{
    public partial class XhinterFaceCheckTicketResultLog
    {
        public long Id { get; set; }
        public string BatchNumber { get; set; }
        public int? RegisterStatus { get; set; }
        public int? CheckStatus { get; set; }
        public string TicketNum { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? CheckTime { get; set; }
    }
}
