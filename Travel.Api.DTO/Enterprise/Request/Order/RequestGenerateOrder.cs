using System;
using System.Collections.Generic;

namespace QiShiShe.Api.DTO.Enterprise.Request.Order {
    public class RequestGenerateOrder:RequestOriBaseModel {
        public int BookingType { get; set; }

        public int? TravelType { get; set; }

        public DateTime? DepartDate { get; set; }

        public DateTime? ArriveDate { get; set; }

        public string DepartCity { get; set; }

        public string ArriveCity { get; set; }

        public int? TravelWay { get; set; }

        public string ExpectDepartTime { get; set; }

        public string ExpectArrivetime { get; set; }

        public string TravelOthers { get; set; }

        public DateTime? HotelCheckinDate { get; set; }
        public DateTime? HotelCheckoutDate { get; set; }

        public int? HotelType { get; set; }

        public string Destination { get; set; }

        public int? HotelLocation { get; set; }

        public string HotelOthers { get; set; }

        public List<Apartment> Apartments { get; set; }

        public List<Passenger> Passengers { get; set; }

        public int EnterpriseId { get; set; }

        public int StaffId { get; set; }
    }

    public class Apartment {
        public int ApartmentType { get; set; }

        public int Apartmentcount { get; set; }
    }
    public class Passenger {
        public string PassengerName { get; set; }

        public string PassengerCardNo { get; set; }
    }
}
