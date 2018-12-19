using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTLOGModels
{
    public partial class InterFaceApimonitorLog
    {
        public long Id { get; set; }
        public int LogType { get; set; }
        public string InterFaceName { get; set; }
        public int MasterInterfaceCode { get; set; }
        public int SubInterfaceCode { get; set; }
        public string RequestJson { get; set; }
        public string ResponseJson { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? RequestTime { get; set; }
        public DateTime? ResponseTime { get; set; }
        public int? TimeDifference { get; set; }
        public DateTime? CreateTime { get; set; }
        public string MonitorNumber { get; set; }
    }
}
