using PetaPoco.NetCore;
using QiShiShe.Entity.Model;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class DepartmentRep {
        public object Insert(Department model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
        public int Update(Department model) {
            return QISHISHEDB.GetInstance().Update(model);
        }
        public int Delete(Department model) {
            return QISHISHEDB.GetInstance().Delete(model);
        }
        public Department GetDepartment(Department model) {
            #region sql
            string wherestr = string.Empty;
            if (model.DepartmentId>0) {
                wherestr += " AND DepartmentId = @0";
            }
            string sql = string.Format(@"
            SELECT  *
            FROM    dbo.Department
            WHERE   1 = 1
            {0}
            ", wherestr);
            #endregion
            return QISHISHEDB.GetInstance().SingleOrDefault<Department>(sql,
                              model.DepartmentId);
        }
        public Page<Department> GetDepartmentList(Department model,int pageindex, int pagesize) {
            string sql = string.Empty;
            string wherestr = string.Empty;
            if (model.EnterpriseId > 0) {
                wherestr += " AND EnterpriseId = @0";
            }
            sql = string.Format(@"
SELECT  *
FROM    dbo.Department
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Page<Department>(pageindex, pagesize, sql, model.EnterpriseId);
        }

        public int UpdateDepartment(Department model) {
            string sql = string.Empty;
            string wherestr = string.Empty;

            if (model.EnterpriseId > 0) {
                wherestr += " AND EnterpriseId = @0";
            }
            if (model.EnterpriseId > 0) {
                wherestr += " AND DepartmentId = @1";
            }
            sql = string.Format(@"
SET DepartmentName=@2,UpdateTime=@3
", wherestr);
            return QISHISHEDB.GetInstance().Update<Department>(sql, model.EnterpriseId, model.DepartmentId, model.DepartmentName, model.UpdateTime);
        }
    }
}
