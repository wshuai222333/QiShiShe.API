using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Middle
{
    public class SelectAirTicketExtenModel
    {
        public int? TravelType { get; set; }

        public string DepartDate { get; set; }

        public string ArriveDate { get; set; }

        public string Citys { get; set; }

        public string FightNos { get; set; }

        public int? SeatType { get; set; }

        public decimal? TicketPrice { get; set; }

        public decimal? FuelPrice { get; set; }

    }
}
