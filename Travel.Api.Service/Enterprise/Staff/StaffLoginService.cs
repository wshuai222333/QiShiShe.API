using QiShiShe.Api.DTO.Enterprise.Request.Staff;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Enterprise {
    public class StaffLoginService : ApiOriBase<RequestStaffLogin> {
        #region 注入服务
        public StaffRep staffRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var staff = new Staff() {
                UserName = this.Parameter.UserName,
                UserPwd = this.Parameter.UserPwd
            };
            var user = staffRep.StaffLogin(staff);
            if (user!=null) {
                this.Result.Data = staffRep.StaffLogin(staff);
            } else {
                throw new AggregateException("用户名或密码不正确！");
            }
        }
    }
}
