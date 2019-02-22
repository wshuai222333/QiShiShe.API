using QiShiShe.Entity.Model;
using System.Collections.Generic;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe
{
    public class SelectTrainTicketRep
    {
        public object Insert(SelectTrainTicket model)
        {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public int Delete(SelectTrainTicket model) {
            return QISHISHEDB.GetInstance().Delete<SelectTrainTicket>(model.SelectTrainTicketId);
        }
        public List<SelectTrainTicket> GetSelectTrainTicketList(string OrderId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.SelectTrainTicket
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Fetch<SelectTrainTicket>(sql, OrderId);
        }

        public SelectTrainTicket GetSelectTrainTicketById(int SelectTrainTicketId)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND SelectTrainTicketId = @0";

            sql = string.Format(@"
SELECT  *
FROM    dbo.SelectTrainTicket
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().SingleOrDefault<SelectTrainTicket>(sql, SelectTrainTicketId);
        }
    }
}
