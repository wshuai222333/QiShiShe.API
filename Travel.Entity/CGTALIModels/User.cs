using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTALIModels
{
    public partial class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public long RoleId { get; set; }
        public int UserType { get; set; }
        public int UserStatus { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? CreateUserId { get; set; }
        public long? UpdateUserId { get; set; }
        public string PayCenterCode { get; set; }
    }
}
