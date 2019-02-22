using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.Api.Service.Boss.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class DeleteSelectTrainTicketService : ApiOriBase<RequestDeleteSelectTrainTicket> {
        #region 注入服务
        public SelectTrainTicketRep selectTrainTicketRep { get; set; }
        #endregion
        protected override void ExecuteMethod() {
            var selectTrainTicket = new SelectTrainTicket() {
                 SelectTrainTicketId = this.Parameter.SelectTrainTicketId
            };
            this.Result.Data = selectTrainTicketRep.Delete(selectTrainTicket);
        }
    }
}
