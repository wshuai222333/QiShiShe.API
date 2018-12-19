using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class ErrorInfo
    {
        public int ErrorId { get; set; }
        public int PlatformType { get; set; }
        public string PlatformErrorCode { get; set; }
        public string PlatformErrorMsg { get; set; }
        public string SyatemCode { get; set; }
        public string SyatemMsg { get; set; }
        public int? ErrorWhere { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserId { get; set; }
    }
}
