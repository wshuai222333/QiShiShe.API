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
    }
}
