using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTLOGModels
{
    public partial class PhoneMessageLog
    {
        public long Id { get; set; }
        public int? MessageType { get; set; }
        public string MessageContent { get; set; }
        public string Phone { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateUserId { get; set; }
    }
}
