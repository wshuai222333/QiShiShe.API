using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class AbeerrorInfo
    {
        public long Id { get; set; }
        public string OrderId { get; set; }
        public string Pnrcontent { get; set; }
        public int ErrorType { get; set; }
        public string ErrorMessage { get; set; }
        public int Status { get; set; }
        public string Abedesc { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string ModifyUser { get; set; }
    }
}
