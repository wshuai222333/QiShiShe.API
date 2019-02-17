using QiShiShe.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe
{
    public class OrderAirTicketRep
    {
        public object Insert(OrderAirTicket model)
        {
            return QISHISHEDB.GetInstance().Insert(model);
        }

        public List<OrderAirTicket> GetOrderAirTicketList(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.OrderAirTicket
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Fetch<OrderAirTicket>(sql, OrderId);
        }
    }
}
