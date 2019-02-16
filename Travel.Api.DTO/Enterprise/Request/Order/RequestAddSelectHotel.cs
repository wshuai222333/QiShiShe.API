using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Enterprise.Request.Order
{
    public class RequestAddSelectHotel : RequestOriBaseModel
    {
        public string OrderId { get; set; }

        public string HotelName { get; set; }

        public string HotelAddress { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
