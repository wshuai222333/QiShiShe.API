using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class BankPayLimitInfo
    {
        public int BankPayLimitInfoId { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string CardKind { get; set; }
        public string BusinessType { get; set; }
        public string SingleMoney { get; set; }
        public string DayMoney { get; set; }
        public string Mobile { get; set; }
        public string Remark { get; set; }
        public Guid? TableId { get; set; }
    }
}
