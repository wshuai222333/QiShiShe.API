using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request.Order
{
    public class RequestUpdateDemandOrderStatus : RequestOriBaseModel
    {
        public string OrderId { get; set; }

        public int Status { get; set; }
    }
}
