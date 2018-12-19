using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class LoginTokenInfo
    {
        public long Id { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Ip { get; set; }
        public string Mac { get; set; }
    }
}
