using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class MessageManage
    {
        public int Id { get; set; }
        public long? UserId { get; set; }
        public int? ManageType { get; set; }
        public string MobilePhone { get; set; }
        public string MessageNote { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? OperationUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? TableId { get; set; }
    }
}
