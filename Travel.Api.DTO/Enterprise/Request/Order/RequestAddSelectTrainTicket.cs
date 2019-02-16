using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Enterprise.Request.Order
{
    public class RequestAddSelectTrainTicket : RequestOriBaseModel
    {
        public string OrderId { get; set; }

        public DateTime OneDepartDate { get; set; }

        public DateTime OneArriveDate { get; set; }

        public DateTime TwoDepartDate { get; set; }

        public DateTime TwoArriveDate { get; set; }

        public string DepartCity { get; set; }

        public string ArriveCity { get; set; }

        public string OneTrainNo { get; set; }

        public string TwoTrainNo { get; set; }
        public int SeatType { get; set; }

        public decimal TicketPrice { get; set; }
        public int TravelType { get; set; }
    }
}
