using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class UserAccount
    {
        public Guid? TableId { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserPwd { get; set; }
        public string RealName { get; set; }
        public string IdNumber { get; set; }
        public string BankCardNumber { get; set; }
        public string Phone { get; set; }
        public string Ip { get; set; }
        public int Status { get; set; }
        public string ReapalMemberNo { get; set; }
        public string ReapalBindId { get; set; }
        public string ReapalMerchantId { get; set; }
        public int? UserType { get; set; }
        public string PartnerCode { get; set; }
        public int? Vip { get; set; }
        public int? IsOnVip { get; set; }
        public string TicketDelayEmail { get; set; }
        public string MerchantCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? ModifyUserId { get; set; }
        public decimal? BillLateFee { get; set; }
        public int? InsuranceBillDays { get; set; }
        public string UserCompanyName { get; set; }
        public string ReapalUserKey { get; set; }
        public string PayCenterCode { get; set; }
        public string LccreceivesEmail { get; set; }
        public decimal? FactoringInterestRate { get; set; }
        public int? GraceCount { get; set; }
        public int? OverdueCount { get; set; }
        public int? GraceDay { get; set; }
        public string ModifyName { get; set; }
        public decimal? GraceBate { get; set; }
        public decimal? OverdueBate { get; set; }
        public decimal? CreditAmount { get; set; }
        public string UserFactoringCode { get; set; }
        public int? IsInsurance { get; set; }
        public int? IsAliUser { get; set; }
    }
}
