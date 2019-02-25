using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Api.DTO.Middle;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class GetOrderAirTicketListService : ApiOriBase<RequestGetSelectAirTicketList> {
        #region 注入服务
        public OrderAirTicketRep orderAirTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod() {
            var data = orderAirTicketRep.GetOrderAirTicketList(this.Parameter.OrderId);

            var list = new List<SelectAirTicketExtenModel>();
            foreach (var item in data) {
                var model = new SelectAirTicketExtenModel();

                model.SelectAirTicketId = item.OrderAirTicketId;
                model.TravelType = item.TravelType;
                model.FuelPrice = item.FuelAirPrice;
                model.SeatType = item.SeatType;
                model.Citys = item.DepartCity + "-" + item.ArriveCity;
                model.FightNos = item.OneFightNo + "/" + item.TwoFightNo;
                model.TicketPrice = item.TicketPrice;
                model.DepartDate = Convert.ToDateTime(item.OneDepartDate).ToString("yyyy-MM-dd HH:mm") + "-" + Convert.ToDateTime(item.OneArriveDate).ToString("HH:mm");
                if (item.TravelType>0) {
                    model.ArriveDate = Convert.ToDateTime(item.TwoDepartDate).ToString("yyyy-MM-dd HH:mm") + "-" + Convert.ToDateTime(item.TwoDepartDate).ToString("HH:mm");
                }
                model.AirTicketRules = item.AirTicketRules;

                list.Add(model);
            }

            this.Result.Data = list;
        }
    }
}
