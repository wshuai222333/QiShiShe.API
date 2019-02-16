using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service
{
    public class GetSelectAirTicketTopService : ApiOriBase<RequestGetSelectAirTicketList>
    {
        #region 注入服务
        public SelectAirTicketRep selectAirTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod()
        {
           this.Result.Data = selectAirTicketRep.GetSelectAirTicketTop(this.Parameter.OrderId);
        }
    }
}
