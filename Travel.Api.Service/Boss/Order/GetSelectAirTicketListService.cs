using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Api.DTO.Middle;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System.Collections.Generic;
using System;

namespace QiShiShe.Api.Service.Boss
{
    public class GetSelectAirTicketListService : ApiOriBase<RequestGetSelectAirTicketList>
    {
        #region 注入服务
        public SelectAirTicketRep selectAirTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod()
        {
            var data = selectAirTicketRep.GetSelectAirTicketList(this.Parameter.OrderId);

            var list = new List<SelectAirTicketExtenModel>();
            foreach (var item in data)
            {
                var model = new SelectAirTicketExtenModel()
                {
                    TravelType = item.TravelType,
                    FuelPrice = item.FuelAirPrice,
                    SeatType = item.SeatType,
                    Citys = item.DepartCity + "-" + item.ArriveCity,
                    FightNos = item.OneFightNo + "/" + item.TwoFightNo,
                    TicketPrice = item.TicketPrice,
                    DepartDate = Convert.ToDateTime(item.OneDepartDate).ToString("yyyy-MM-dd HH:mm") + "-" + Convert.ToDateTime(item.OneArriveDate).ToString("HH:mm"),
                    ArriveDate = Convert.ToDateTime(item.TwoDepartDate).ToString("yyyy-MM-dd HH:mm") + "-" + Convert.ToDateTime(item.TwoDepartDate).ToString("HH:mm"),

                };
                list.Add(model);
            }

            this.Result.Data = list;
        }
    }
}
