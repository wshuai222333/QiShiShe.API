using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Api.DTO.Middle;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;

namespace QiShiShe.Api.Service.Boss
{
    public class GetSelectTrainTicketListService : ApiOriBase<RequestGetSelectTrainTicketList>
    {
        #region 注入服务
        public SelectTrainTicketRep selectTrainTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod()
        {
            var data = selectTrainTicketRep.GetSelectTrainTicketList(this.Parameter.OrderId);

            var list = new List<SelectTrainTicketExtenModel>();
            foreach (var item in data)
            {
                var model = new SelectTrainTicketExtenModel()
                {
                    TravelType = item.TravelType,
                    SeatType = item.SeatType,
                    Citys = item.DepartCity + "-" + item.ArriveCity,
                    TrainNos = item.OneTrainNo + "/" + item.TwoTrainNo,
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
