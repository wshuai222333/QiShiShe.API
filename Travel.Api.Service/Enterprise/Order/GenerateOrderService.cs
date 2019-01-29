using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service {
    public class GenerateOrderService : ApiOriBase<RequestGenerateOrder> {
        #region 注入服务
        public DemandOrderRep demandOrderRep { get; set; }

        public OrderPassengerRep orderPassengerRep { get; set; }

        public OrderApartmentRep orderApartmentRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            try {
                var demandOrder = new DemandOrder() {
                    ArriveCity = this.Parameter.ArriveCity,
                    ArriveDate = this.Parameter.ArriveDate,
                    BookingType = this.Parameter.BookingType,
                    DepartCity = this.Parameter.DepartCity,
                    DepartDate = this.Parameter.DepartDate,
                    Destination = this.Parameter.Destination,
                    ExpectArrivetime = this.Parameter.ExpectArrivetime,
                    ExpectDepartTime = this.Parameter.ExpectDepartTime,
                    HotelCheckinDate = this.Parameter.HotelCheckinDate,
                    HotelCheckoutDate = this.Parameter.HotelCheckoutDate,
                    HotelLocation = this.Parameter.HotelLocation,
                    HotelOthers = this.Parameter.HotelOthers,
                    HotelType = this.Parameter.HotelType,
                    TravelOthers = this.Parameter.TravelOthers,
                    TravelType = this.Parameter.TravelType,
                    TravelWay = this.Parameter.TravelWay,
                    CreateTime = DateTime.Now
                };
                foreach (var passenger in this.Parameter.Passengers) {
                    var orderPassenger = new OrderPassenger() {
                        CreateTime = DateTime.Now,
                        PassengerName = passenger.PassengerName,
                        PassengerCardNo = passenger.PassengerCardNo
                    };
                    orderPassengerRep.Insert(orderPassenger);
                };
                foreach (var apartment in this.Parameter.Apartments) {
                    var orderApartment = new OrderApartment() {
                        CreateTime = DateTime.Now,
                        Apartmentcount = apartment.Apartmentcount,
                        ApartmentType = apartment.ApartmentType
                    };
                    orderApartmentRep.Insert(orderApartment);
                }
                this.Result.Data = demandOrderRep.Insert(demandOrder);
            } catch(Exception ex) {
                throw new AggregateException(ex);
            }
        }
    }
}
