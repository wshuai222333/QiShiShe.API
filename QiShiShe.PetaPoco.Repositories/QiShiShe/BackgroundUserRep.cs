using PetaPoco.NetCore;
using QiShiShe.Entity.Model;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class BackgroundUserRep {
        public object Insert(BackgroundUser model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public int Update(BackgroundUser model) {
            return QISHISHEDB.GetInstance().Update(model);
        }
        public int Delete(BackgroundUser model) {
            return QISHISHEDB.GetInstance().Delete(model);
        }
        public BackgroundUser GetBackgroundUser(BackgroundUser model) {
            #region sql
            string wherestr = string.Empty;
            if (!string.IsNullOrEmpty(model.UserName)) {
                wherestr += " AND UserName = @0";
            }
            if (!string.IsNullOrEmpty(model.UserPwd)) {
                wherestr += " AND UserPwd = @1 ";
            }
            string sql = string.Format(@"
            SELECT  *
            FROM    dbo.BackgroundUser
            WHERE   1 = 1
            {0}
            ", wherestr);
            #endregion
            return QISHISHEDB.GetInstance().SingleOrDefault<BackgroundUser>(sql,
                              model.UserName, model.UserPwd);
        }
        public Page<BackgroundUser> GetBackgroundUserList(int pageindex, int pagesize) {
            string sql = string.Empty;
            string wherestr = string.Empty;

            sql = string.Format(@"
SELECT  *
FROM    dbo.BackgroundUser
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Page<BackgroundUser>(pageindex, pagesize, sql);
        }
    }
}
