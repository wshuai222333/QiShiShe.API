using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class AddSelectTrainTicketService : ApiOriBase<RequestAddSelectTrainTicket> {
        #region 注入服务
        public SelectTrainTicketRep selectTrainTicketRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod() {
            var selectTrainTicket = new SelectTrainTicket() {
                ArriveCity = this.Parameter.ArriveCity,
                DepartCity = this.Parameter.DepartCity,
                OrderId = this.Parameter.OrderId,
                SeatType = this.Parameter.SeatType,
                CreateTime = DateTime.Now,

                OneArriveDate = this.Parameter.OneArriveDate,
                OneDepartDate = this.Parameter.OneDepartDate,
                OneTrainNo = this.Parameter.OneTrainNo,
                TicketPrice = this.Parameter.TicketPrice,
                TwoArriveDate = this.Parameter.TwoArriveDate,
                TwoDepartDate = this.Parameter.TwoDepartDate,
                TwoTrainNo = this.Parameter.TwoTrainNo,
                TravelType = this.Parameter.TravelType,
                TrainTicketRules = this.Parameter.TrainTicketRules
            };
            this.Result.Data = selectTrainTicketRep.Insert(selectTrainTicket);
        }
    }
}
