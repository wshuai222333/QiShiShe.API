using PetaPoco.NetCore;
using QiShiShe.Entity.Model;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public  class StaffRep {
        public object Insert(Staff model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public int Update(Staff model) {
            return QISHISHEDB.GetInstance().Update(model);
        }
        public int Delete(Staff model) {
            return QISHISHEDB.GetInstance().Delete(model);
        }
        public Staff GetStaff(Staff model) {
            #region sql
            string wherestr = string.Empty;
            if (model.StaffId > 0) {
                wherestr += " AND DepartmentId = @0";
            }
            string sql = string.Format(@"
            SELECT  *
            FROM    dbo.Staff
            WHERE   1 = 1
            {0}
            ", wherestr);
            #endregion
            return QISHISHEDB.GetInstance().SingleOrDefault<Staff>(sql,
                              model.StaffId);
        }
        public Page<Staff> GetDepartmentList(int pageindex, int pagesize) {
            string sql = string.Empty;
            string wherestr = string.Empty;

            sql = string.Format(@"
SELECT  *
FROM    dbo.Staff
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Page<Staff>(pageindex, pagesize, sql);
        }
    }
}
