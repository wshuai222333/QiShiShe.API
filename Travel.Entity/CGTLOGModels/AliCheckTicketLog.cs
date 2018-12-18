using System;
using Travel.DDD.Domain;

namespace Travel.Entity.CGTLOGModels {
    public partial class AliCheckTicketLog: EntityBase {
        public int AliCheckTicketLogId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? RequestTime { get; set; }
        public string TikcetNo { get; set; }
        public DateTime? ReturnTime { get; set; }
        public string ReturnResult { get; set; }
        public string ReturnMessage { get; set; }

        public int? IsSuccess { get; set; }

        public string MerchantId { get; set; }
    }
}
