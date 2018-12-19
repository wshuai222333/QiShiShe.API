using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class HistoryPartnerInfo
    {
        public int Id { get; set; }
        public int? UaccountId { get; set; }
        public string HisPartnerCode { get; set; }
        public string PartnerCode { get; set; }
        public string MerchantName { get; set; }
        public string Operation { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
