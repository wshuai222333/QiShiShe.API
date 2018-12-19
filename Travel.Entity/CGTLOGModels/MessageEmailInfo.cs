using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTLOGModels
{
    public partial class MessageEmailInfo
    {
        public long EmailId { get; set; }
        public string MsgTitle { get; set; }
        public long? MessageId { get; set; }
    }
}
