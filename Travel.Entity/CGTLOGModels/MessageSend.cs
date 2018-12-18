using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTLOGModels
{
    public partial class MessageSend
    {
        public long Id { get; set; }
        public int? MessageType { get; set; }
        public string MsgContent { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string FormUserName { get; set; }
        public string FormUserPwd { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public int? Status { get; set; }
    }
}
