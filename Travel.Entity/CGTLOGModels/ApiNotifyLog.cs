using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTLOGModels
{
    public partial class ApiNotifyLog
    {
        public int Id { get; set; }
        public Guid TableId { get; set; }
        public int? InterfaceType { get; set; }
        public int? BusinessType { get; set; }
        public DateTime? CreateTime { get; set; }
        public string NodifyParameter { get; set; }
        public int? NodifyStatus { get; set; }
        public string ReNodifyParameter { get; set; }
        public string OrderId { get; set; }
        public string BillId { get; set; }
        public string MerchantName { get; set; }
        public string ReapayMerchantNo { get; set; }
        public string MerchantCode { get; set; }
    }
}
