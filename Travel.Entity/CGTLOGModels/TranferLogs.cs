using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTLOGModels
{
    public partial class TranferLogs
    {
        public int Id { get; set; }
        public string CompanyOrderId { get; set; }
        public string ReapalNo { get; set; }
        public string CompanyCode { get; set; }
        public string StepNo { get; set; }
        public decimal? Amount { get; set; }
        public string PayAccount { get; set; }
        public string MerchantNo { get; set; }
        public string RequestDecryptParams { get; set; }
        public string ResponseDecryptParams { get; set; }
        public int? ReturnStatus { get; set; }
        public string ReturnErrorMessage { get; set; }
        public string ErrorMessage { get; set; }
        public int? ExpenditureId { get; set; }
        public int? IncomeId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CompanyName { get; set; }
        public Guid? TableId { get; set; }
    }
}
