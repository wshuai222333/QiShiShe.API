using QiShiShe.Entity.Model;
using System.Collections.Generic;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe
{
    public class SelectAirTicketRep
    {
        public object Insert(SelectAirTicket model)
        {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public int Delete(SelectAirTicket model) {
            return QISHISHEDB.GetInstance().Delete<SelectAirTicket>(model.SelectAirTicketId);
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
        public SelectAirTicket GetSelectAirTicketTop(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.SelectAirTicket
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().SingleOrDefault<SelectAirTicket>(sql, OrderId);
        }
        public SelectAirTicket GetSelectAirTicketById(int SelectAirTicketId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND SelectAirTicketId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.SelectAirTicket
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().SingleOrDefault<SelectAirTicket>(sql, SelectAirTicketId);
        }
    }
}
