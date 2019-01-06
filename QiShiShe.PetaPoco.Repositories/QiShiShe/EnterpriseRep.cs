using PetaPoco.NetCore;
using QiShiShe.Entity.Model;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class EnterpriseRep {
        public object Insert(Enterprise model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public int Delete(Enterprise model) {
            return QISHISHEDB.GetInstance().Delete(model);
        }
        public int Update(Enterprise model) {
            return QISHISHEDB.GetInstance().Update(model);
        }
        public Enterprise GetEnterprise(Enterprise model) {
            #region sql
            string wherestr = string.Empty;
            if (model.EnterpriseId>0) {
                wherestr += " AND EnterpriseId = @0";
            }
            string sql = string.Format(@"
            SELECT  *
            FROM    dbo.Enterprise
            WHERE   1 = 1
            {0}
            ", wherestr);
            #endregion
            return QISHISHEDB.GetInstance().SingleOrDefault<Enterprise>(sql,
                              model.EnterpriseId);
        }
        public Page<Enterprise> GetEnterpriseList(int pageindex, int pagesize) {
            string sql = string.Empty;
            string wherestr = string.Empty;

            sql = string.Format(@"
SELECT  *
FROM    dbo.Enterprise
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Page<Enterprise>(pageindex, pagesize, sql);
        }
        public int UpdateEnterprise(Enterprise model) {
            string sql = string.Empty;
            string wherestr = string.Empty;

            if (model.EnterpriseId > 0) {
                wherestr += " AND EnterpriseId = @0";
            }
            sql = string.Format(@"
SET EnterpriseName=@1,EnterpriseCode = @2,ContactsName=@3,ContactsPhone = @4,ContactsEmail=@5,UpdateTime=@6
WHERE 1=1 {0}
", wherestr);
            return QISHISHEDB.GetInstance().Update<Enterprise>(sql,model.EnterpriseId, model.EnterpriseName, model.EnterpriseCode, model.ContactsName, model.ContactsPhone,model.ContactsEmail, model.UpdateTime);
        }
    }
}
