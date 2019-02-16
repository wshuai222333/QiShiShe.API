using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request.Order
{
    public class RequestGetOrderPassengerList : RequestOriBaseModel
    {
        public string OrderId { get; set; }
    }
}
