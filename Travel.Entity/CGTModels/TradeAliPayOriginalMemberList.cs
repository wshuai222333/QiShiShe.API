using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class TradeAliPayOriginalMemberList
    {
        public long Id { get; set; }
        public string TransactionNo { get; set; }
        public string MerchantOrderNo { get; set; }
        public DateTime? CreateTranTime { get; set; }
        public string PayTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string TranSource { get; set; }
        public string TypeDes { get; set; }
        public string CounterParty { get; set; }
        public string TradeName { get; set; }
        public decimal? Price { get; set; }
        public string BalancePayment { get; set; }
        public string TradeStatusDes { get; set; }
        public string ServiceCharge { get; set; }
        public decimal? SuccessRefund { get; set; }
        public string Remark { get; set; }
        public string FromUrl { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
