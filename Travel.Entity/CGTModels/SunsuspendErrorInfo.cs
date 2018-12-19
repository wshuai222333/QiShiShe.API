using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class SunsuspendErrorInfo
    {
        public int SunsuspendId { get; set; }
        public long? TradeId { get; set; }
        public string PlatformOrderId { get; set; }
        public int? Category { get; set; }
        public string ReMoneyName { get; set; }
        public string MerchantId { get; set; }
        public string ErrorDescript { get; set; }
        public int? ErrorType { get; set; }
        public int? TicketType { get; set; }
        public string OperationUser { get; set; }
        public int? Status { get; set; }
        public int? SuStatus { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? TableId { get; set; }
        public string ServiceUrl { get; set; }
        public string PersonalMerchantNo { get; set; }
        public string StartDate { get; set; }
        public string Amount { get; set; }
        public string AccountType { get; set; }
        public string ReturnAmountAccount { get; set; }
        public string NotifyUrl { get; set; }
        public decimal? NumberRefundRebate { get; set; }
    }
}
