using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss
{
    public class AddSelectAirTicketService : ApiOriBase<RequestAddSelectAirTicket>
    {
        #region 注入服务
        public SelectAirTicketRep selectAirTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod()
        {
            var selectAirTicket = new SelectAirTicket()
            {
                ArriveCity = this.Parameter.ArriveCity,
                ArriveDate = this.Parameter.ArriveDate,
                DepartCity = this.Parameter.DepartCity,
                DepartDate = this.Parameter.DepartDate,
                FightNo = this.Parameter.FightNo,
                OrderId = this.Parameter.OrderId,
                SeatType = this.Parameter.SeatType
                  
            };
            this.Result.Data = selectAirTicketRep.Insert(selectAirTicket);
        }
    }
}
