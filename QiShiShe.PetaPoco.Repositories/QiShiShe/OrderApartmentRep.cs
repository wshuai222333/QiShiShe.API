﻿using QiShiShe.Entity.Model;
using System.Collections.Generic;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class OrderApartmentRep {
        public object Insert(OrderApartment model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public List<OrderApartment> GetOrderApartmentList(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.OrderApartment
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Fetch<OrderApartment>(sql, OrderId);
        }
    }
}
