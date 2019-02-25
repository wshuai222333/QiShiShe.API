using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Api.DTO.Middle;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class GetOrderTrainTicketListService : ApiOriBase<RequestGetSelectTrainTicketList> {
        #region 注入服务
        public OrderTrainTicketRep orderTrainTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod() {
            var data = orderTrainTicketRep.GetOrderTrainTicketList(this.Parameter.OrderId);

            var list = new List<SelectTrainTicketExtenModel>();
            foreach (var item in data) {
                var model = new SelectTrainTicketExtenModel();

                model.SelectTrainTicketId = item.OrderTrainTicketId;
                model.TravelType = item.TravelType;
                model.SeatType = item.SeatType;
                model.Citys = item.DepartCity + "-" + item.ArriveCity;
                model.TrainNos = item.OneTrainNo + "/" + item.TwoTrainNo;
                model.TicketPrice = item.TicketPrice;
                model.DepartDate = Convert.ToDateTime(item.OneDepartDate).ToString("yyyy-MM-dd HH:mm") + "-" + Convert.ToDateTime(item.OneArriveDate).ToString("HH:mm");
                if (item.TravelType > 0) {
                    model.ArriveDate = Convert.ToDateTime(item.TwoDepartDate).ToString("yyyy-MM-dd HH:mm") + "-" + Convert.ToDateTime(item.TwoDepartDate).ToString("HH:mm");
                }
                model.ArriveDate = Convert.ToDateTime(item.TwoDepartDate).ToString("yyyy-MM-dd HH:mm") + "-" + Convert.ToDateTime(item.TwoDepartDate).ToString("HH:mm");
                model.TrainTicketRules = item.TrainTicketRules;
                list.Add(model);
            }

            this.Result.Data = list;
        }
    }
}
