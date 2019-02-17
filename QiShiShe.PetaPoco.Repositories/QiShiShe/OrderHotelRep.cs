using QiShiShe.Entity.Model;
using System.Collections.Generic;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe
{
    public class OrderHotelRep
    {
        public object Insert(OrderHotel model)
        {
            return QISHISHEDB.GetInstance().Insert(model);
        }

        public List<OrderHotel> GetOrderHotelList(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.OrderHotel
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Fetch<OrderHotel>(sql, OrderId);
        }

    }
}
