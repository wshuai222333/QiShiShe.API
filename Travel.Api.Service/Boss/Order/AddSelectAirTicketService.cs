using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class AddSelectAirTicketService : ApiOriBase<RequestAddSelectAirTicket> {
        #region 注入服务
        public SelectAirTicketRep selectAirTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod() {
            var selectAirTicket = new SelectAirTicket() {
                ArriveCity = this.Parameter.ArriveCity,
                DepartCity = this.Parameter.DepartCity,
                OrderId = this.Parameter.OrderId,
                SeatType = this.Parameter.SeatType,
                CreateTime = DateTime.Now,
                FuelAirPrice = this.Parameter.FuelAirPrice,
                OneArriveDate = this.Parameter.OneArriveDate,
                OneDepartDate = this.Parameter.OneDepartDate,
                OneFightNo = this.Parameter.OneFightNo,
                TicketPrice = this.Parameter.TicketPrice,
                TwoArriveDate = this.Parameter.TwoArriveDate,
                TwoDepartDate = this.Parameter.TwoDepartDate,
                TwoFightNo = this.Parameter.TwoFightNo,
                TravelType = this.Parameter.TravelType,
                AirTicketRules = this.Parameter.AirTicketRules
            };
            this.Result.Data = selectAirTicketRep.Insert(selectAirTicket);
        }
    }
}
