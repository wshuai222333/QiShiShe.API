using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TicketUserInfo
    {
        public long Id { get; set; }
        public long? CgtuserId { get; set; }
        public int PlatformType { get; set; }
        public string UserName { get; set; }
        public string AgentCode { get; set; }
        public string InterfacePwd { get; set; }
        public string SafetyCode { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ModifyUser { get; set; }
        public long? ModifyUserId { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string AddUser { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
