using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Middle
{
    public class SelectTrainTicketExtenModel
    {
        public int? TravelType { get; set; }

        public string DepartDate { get; set; }

        public string ArriveDate { get; set; }

        public string Citys { get; set; }

        public string TrainNos { get; set; }

        public int? SeatType { get; set; }

        public decimal? TicketPrice { get; set; }

        public int SelectTrainTicketId { get; set; }

    }
}
