using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTLOGModels
{
    public partial class ApiexceptionLog
    {
        public long Id { get; set; }
        public Guid TableId { get; set; }
        public string MerchantId { get; set; }
        public string Ip { get; set; }
        public string Url { get; set; }
        public string ReturnParams { get; set; }
        public string SubmitParams { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Status { get; set; }
        public string MessageCode { get; set; }
        public string Message { get; set; }
    }
}
