using QiShiShe.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe
{
    public class SelectHotelRep
    {
        public object Insert(SelectHotel model)
        {
            return QISHISHEDB.GetInstance().Insert(model);
        }

        public List<SelectHotel> GetSelectHotelList(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.SelectHotel
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Fetch<SelectHotel>(sql, OrderId);
        }
        public SelectHotel GetSelectHotelById(int SelectHotelId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND SelectHotelId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.SelectHotel
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().SingleOrDefault<SelectHotel>(sql, SelectHotelId);
        }


    }
}
