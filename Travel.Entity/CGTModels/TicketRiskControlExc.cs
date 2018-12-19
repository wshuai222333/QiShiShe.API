using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class TicketRiskControlExc
    {
        public int Id { get; set; }
        public string MerchantCode { get; set; }
        public int? TicketType { get; set; }
        public string OrderId { get; set; }
        public string TicketNo { get; set; }
        public int? ExceptionType { get; set; }
        public string ExceptionDes { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? TableId { get; set; }
    }
}
