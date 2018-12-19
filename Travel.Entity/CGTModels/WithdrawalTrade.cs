using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class WithdrawalTrade
    {
        public long WithdrawalTradeId { get; set; }
        public string MerchantOrderId { get; set; }
        public long? UserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public decimal? Amout { get; set; }
        public string BankNumber { get; set; }
        public string BankOpenName { get; set; }
        public string BankName { get; set; }
        public int? State { get; set; }
        public Guid? TableId { get; set; }
        public string Note { get; set; }
    }
}
