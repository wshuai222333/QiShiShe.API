using QiShiShe.Api.DTO.Boss.Request.Staff;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class UpdateStaffService : ApiOriBase<RequestUpdateStaff> {
        #region 注入服务
        public StaffRep staffRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {

            var staff = new Staff() {
                DepartmentId = this.Parameter.DepartmentId,
                StaffBirthday = this.Parameter.StaffBirthday,
                UpdateTime = DateTime.Now,
                StaffCardNo = this.Parameter.StaffCardNo,
                StaffName = this.Parameter.StaffName,

            };
            this.Result.Data = staffRep.UpdateStaff(staff);
        }
    }
}
