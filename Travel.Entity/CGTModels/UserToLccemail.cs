using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class UserToLccemail
    {
        public long UserToLccemailId { get; set; }
        public long? UserId { get; set; }
        public string AirLineEmail { get; set; }
        public Guid? TableId { get; set; }
        public string Airline { get; set; }
        public string AirlineName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? ModifyUserId { get; set; }
    }
}
