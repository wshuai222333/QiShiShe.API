using PetaPoco.NetCore;
using QiShiShe.Entity.Model;
namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class DemandOrderRep {
        public object Insert(DemandOrder model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public Page<DemandOrder> GetEnterpriseList(int EnterpriseId,int pageindex, int pagesize) {
            string sql = string.Empty;
            string wherestr = string.Empty;
            wherestr += " AND EnterpriseId= @0 ";
             sql = string.Format(@"
SELECT  *
FROM    dbo.DemandOrder
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Page<DemandOrder>(pageindex, pagesize, sql, EnterpriseId);
        }
        public Page<DemandOrder> GetEnterpriseListByBoss(int pageindex, int pagesize) {
            string sql = string.Empty;
            string wherestr = string.Empty;
            sql = string.Format(@"
SELECT  *
FROM    dbo.DemandOrder
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Page<DemandOrder>(pageindex, pagesize, sql);
        }
        public int UpdateDemandOrderStatus(string OrderId,int Status)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SET Status=@1,OperatConfirmTime=getdate()
WHERE 1=1 {0}
", wherestr);
            return QISHISHEDB.GetInstance().Update<DemandOrder>(sql, OrderId, Status);
        }
        public int UpdateOverDemandOrderStatus(string OrderId, int Status)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SET Status=@1,DetermineTime=getdate()
WHERE 1=1 {0}
", wherestr);
            return QISHISHEDB.GetInstance().Update<DemandOrder>(sql, OrderId, Status);
        }
        public int UpdateDemandOrderStatusAndTotalPrice(string OrderId, int Status,decimal? TotalPrice)
        {
            string sql = string.Empty;
            string wherestr = string.Empty;

            wherestr += " AND OrderId = @0";

            sql = string.Format(@"
SET Status=@1,UserConfirmTime=getdate(),TotalPrice = @2
WHERE 1=1 {0}
", wherestr);
            return QISHISHEDB.GetInstance().Update<DemandOrder>(sql, OrderId, Status, TotalPrice);
        }
    }
}
