﻿using QiShiShe.Entity.Model;
using System.Collections.Generic;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe
{
    public class SelectAirTicketRep
    {
        public object Insert(SelectAirTicket model)
        {
            return QISHISHEDB.GetInstance().Insert(model);
        }

        public List<SelectAirTicket> GetSelectAirTicketList(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.SelectAirTicket
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Fetch<SelectAirTicket>(sql, OrderId);
        }
    }
}