using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTLOGModels
{
    public partial class AccountInterfaceLog
    {
        public int Id { get; set; }
        public string Interface { get; set; }
        public string Method { get; set; }
        public string Parameter { get; set; }
        public int? LogType { get; set; }
        public string Message { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
