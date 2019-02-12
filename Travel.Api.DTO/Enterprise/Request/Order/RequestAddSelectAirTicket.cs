using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Enterprise.Request.Order
{
    public class RequestAddSelectAirTicket : RequestOriBaseModel
    {
        public string OrderId { get; set; }

        public DateTime DepartDate { get; set; }

        public DateTime ArriveDate { get; set; }

        public string DepartCity { get; set; }

        public string ArriveCity { get; set; }

        public string FightNo { get; set; }

        public int SeatType { get; set; }
    }
}
