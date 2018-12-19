using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class BillRepayDetail
    {
        public long RepayDetailId { get; set; }
        public long TradeId { get; set; }
        public long BillDetailId { get; set; }
        public Guid? TableId { get; set; }
    }
}
