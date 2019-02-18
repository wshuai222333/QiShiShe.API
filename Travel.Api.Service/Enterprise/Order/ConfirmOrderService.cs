using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service
{
    public class ConfirmOrderService : ApiOriBase<RequestConfirmOrder>
    {
        #region 注入服务
        public DemandOrderRep demandOrderRep { get; set; }

        public SelectAirTicketRep selectAirTicketRep { get; set; }

        public SelectHotelRep selectHotelRep { get; set; }

        public SelectTrainTicketRep selectTrainTicketRep { get; set; }

        public OrderAirTicketRep orderAirTicketRep { get; set; }

        public OrderTrainTicketRep orderTrainTicketRep { get; set; }

        public OrderHotelRep OrderHotelRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod()
        {
            
            var selectAirTicket = selectAirTicketRep.GetSelectAirTicketById(this.Parameter.SelectAirTicketId);

            var selectTrainTicket = selectTrainTicketRep.GetSelectTrainTicketById(this.Parameter.SelectTrainTicketId);

            var selectHotel = selectHotelRep.GetSelectHotelById(this.Parameter.SelectHotelId);

            var orderAirTicket = new OrderAirTicket()
            {
                ArriveCity = selectAirTicket.ArriveCity,
                CreateTime = DateTime.Now,
                DepartCity = selectAirTicket.DepartCity,
                FuelAirPrice = selectAirTicket.FuelAirPrice,
                OneArriveDate = selectAirTicket.OneArriveDate,
                OneDepartDate = selectAirTicket.OneDepartDate,
                OneFightNo = selectAirTicket.OneFightNo,
                OrderId = this.Parameter.OrderId,
                SeatType = selectAirTicket.SeatType,
                TicketPrice = selectAirTicket.TicketPrice,
                TravelType = selectAirTicket.TravelType,
                TwoArriveDate = selectAirTicket.TwoArriveDate,
                TwoDepartDate = selectAirTicket.TwoDepartDate,
                TwoFightNo = selectAirTicket.TwoFightNo
            };
            orderAirTicketRep.Insert(orderAirTicket);

            var orderTrainTicket = new OrderTrainTicket()
            {
                ArriveCity = selectTrainTicket.ArriveCity,
                CreateTime = DateTime.Now,
                DepartCity = selectTrainTicket.DepartCity,
                OneArriveDate = selectTrainTicket.OneArriveDate,
                OneDepartDate = selectTrainTicket.OneDepartDate,
                OneTrainNo = selectTrainTicket.OneTrainNo,
                OrderId = this.Parameter.OrderId,
                SeatType = selectTrainTicket.SeatType,
                TicketPrice = selectTrainTicket.TicketPrice,
                TravelType = selectTrainTicket.TravelType,
                TwoArriveDate = selectTrainTicket.TwoArriveDate,
                TwoDepartDate = selectTrainTicket.TwoDepartDate,
                TwoTrainNo = selectTrainTicket.TwoTrainNo
            };
            orderTrainTicketRep.Insert(orderTrainTicket);

            var orderHotel = new OrderHotel()
            {
                CreateTime = DateTime.Now,
                HotelAddress = selectHotel.HotelAddress,
                HotelName = selectHotel.HotelName,
                OrderId = this.Parameter.OrderId,
                TotalPrice = selectHotel.TotalPrice
            };
            OrderHotelRep.Insert(orderHotel);

            var totalPrice = selectAirTicket.FuelAirPrice + selectAirTicket.TicketPrice + selectTrainTicket.TicketPrice + selectHotel.TotalPrice;

            this.Result.Data = demandOrderRep.UpdateDemandOrderStatusAndTotalPrice(this.Parameter.OrderId,3, totalPrice);

        }
    }
}
