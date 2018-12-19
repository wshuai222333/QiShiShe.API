using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class OfficeNoConfig
    {
        public long Id { get; set; }
        public string AirCompanyCode { get; set; }
        public string OfficeNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string ModifyUser { get; set; }
    }
}
