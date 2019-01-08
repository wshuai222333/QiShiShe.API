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
        public Page<Staff> GetStaffList(int pageindex, int pagesize, Staff model) {
            string sql = string.Empty;
            string wherestr = string.Empty;
            if (model.EnterpriseId > 0) {
                wherestr += " AND EnterpriseId = @0";
            }
            if (!string.IsNullOrWhiteSpace(model.StaffName)) {
                wherestr += " AND StaffName = @1";
            }
            if (!string.IsNullOrWhiteSpace(model.StaffCardNo)) {
                wherestr += " AND StaffCardNo = @2";
            }
            if (!string.IsNullOrWhiteSpace(model.Phone)) {
                wherestr += " AND Phone = @3";
            }
            sql = string.Format(@"
SELECT  *
FROM    dbo.Staff
WHERE 1=1 {0}
ORDER BY CreateTime DESC", wherestr);
            return QISHISHEDB.GetInstance().Page<Staff>(pageindex, pagesize, sql, model.EnterpriseId,model.StaffName,model.StaffCardNo, model.Phone);
        }
        public int UpdateStaff(Staff model) {
            string sql = string.Empty;
            string wherestr = string.Empty;

            if (model.StaffId > 0) {
                wherestr += " AND StaffId = @0";
            }
            sql = string.Format(@"
SET StaffName=@1,StaffBirthday = @2,StaffCardNo=@3,DepartmentId = @4,UpdateTime=@5
WHERE 1=1 {0}
", wherestr);
            return QISHISHEDB.GetInstance().Update<Staff>(sql,model.StaffId, model.StaffName, model.StaffBirthday, model.StaffCardNo, model.DepartmentId, model.UpdateTime);
        }
        public int UpdateIntegral(int StaffId,int Integral) {
            string sql = string.Empty;
            string wherestr = string.Empty;

            if (StaffId > 0) {
                wherestr += " AND StaffId = @0";
            }
            sql = string.Format(@"
SET Integral=Integral+@1
WHERE 1=1 {0}
", wherestr);
            return QISHISHEDB.GetInstance().Update<Staff>(sql, StaffId, Integral);
        }
    }
}
