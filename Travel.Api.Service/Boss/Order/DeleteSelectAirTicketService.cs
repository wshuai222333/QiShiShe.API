using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class DeleteSelectAirTicketService : ApiOriBase<RequestDeleteSelectAirTicket> {
        #region 注入服务
        public SelectAirTicketRep selectAirTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var selectAirTicket = new SelectAirTicket() {
                 SelectAirTicketId = this.Parameter.SelectAirTicketId
            };
            this.Result.Data = selectAirTicketRep.Delete(selectAirTicket);
        }
    }
}
