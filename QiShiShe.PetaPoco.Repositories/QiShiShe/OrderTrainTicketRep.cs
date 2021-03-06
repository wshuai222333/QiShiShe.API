﻿using QiShiShe.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe
{
    public class OrderTrainTicketRep
    {
        public object Insert(OrderTrainTicket model)
        {
            return QISHISHEDB.GetInstance().Insert(model);
        }

        public List<OrderTrainTicket> GetOrderTrainTicketList(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.OrderTrainTicket
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Fetch<OrderTrainTicket>(sql, OrderId);
        }
    }
}
