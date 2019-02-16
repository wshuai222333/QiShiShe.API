using QiShiShe.Entity.Model;
using System.Collections.Generic;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe
{
    public class OrderPassengerRep {
        public object Insert(OrderPassenger model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public List<OrderPassenger> GetOrderPassengerList(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.OrderPassenger
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Fetch<OrderPassenger>(sql, OrderId);
        }
    }
}
