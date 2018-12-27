using QiShiShe.Api.DTO.Boss.Request.Staff;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class AddStaffService : ApiOriBase<RequestAddStaff> {
        #region 注入服务
        public StaffRep staffRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var staff = new Staff() {
                DepartmentId = this.Parameter.DepartmentId,
                EnterpriseId = this.Parameter.EnterpriseId,
                StaffBirthday = this.Parameter.StaffBirthday,
                CreateTime = DateTime.Now,
                StaffCardNo = this.Parameter.StaffCardNo,
                StaffIName = this.Parameter.StaffIName,

            };
            this.Result.Data = staffRep.Insert(staff);
        }
    }
}
