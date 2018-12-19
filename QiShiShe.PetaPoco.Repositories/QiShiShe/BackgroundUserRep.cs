using QiShiShe.Entity.Model;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class BackgroundUserRep {
        public object Insert(BackgroundUser model) {
            return QISHISHEDB.GetInstance().Insert(model);
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
    }
}
