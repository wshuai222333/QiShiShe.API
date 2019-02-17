using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Enterprise.Request.Order
{
    public class RequestConfirmOrder:RequestOriBaseModel 
    {
        public string OrderId { get; set; }

        public int SelectAirTicketId { get; set; }

        public int SelectTrainTicketId { get; set; }

        public int SelectHotelId { get; set; }

    }
    
}
