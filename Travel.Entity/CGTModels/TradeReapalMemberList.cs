using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TradeReapalMemberList
    {
        public long Id { get; set; }
        public int TransType { get; set; }
        public string TransName { get; set; }
        public decimal TransAmount { get; set; }
        public string TransNo { get; set; }
        public int TransStatus { get; set; }
        public string TransCreateTime { get; set; }
        public string CreateTime { get; set; }
        public string FromAccountName { get; set; }
        public string ToAccountName { get; set; }
        public string MerchantOrderNo { get; set; }
        public int? TransferBillType { get; set; }
        public string Remark1 { get; set; }
        public string PlateCode { get; set; }
        public int? IsaLiPay { get; set; }
        public int? IsBill { get; set; }
        public string RefundTicketId { get; set; }
        public int? IsWallet { get; set; }
    }
}
