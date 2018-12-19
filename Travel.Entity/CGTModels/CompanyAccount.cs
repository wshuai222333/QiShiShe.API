using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class CompanyAccount
    {
        public long CompanyId { get; set; }
        public long UserId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAccountName { get; set; }
        public string CompanyReapalNo { get; set; }
        public string PartnerCode { get; set; }
        public int Vip { get; set; }
        public string Yyzzurl { get; set; }
        public string Zzjgurl { get; set; }
        public string Swdjurl { get; set; }
        public string Czdjurl { get; set; }
        public string Yhkhurl { get; set; }
        public string Iataurl { get; set; }
        public bool IsThreeInOne { get; set; }
        public long CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
