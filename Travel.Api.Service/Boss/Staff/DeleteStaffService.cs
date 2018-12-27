using QiShiShe.Api.DTO.Boss.Request.Staff;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss {
    public class DeleteStaffService : ApiOriBase<RequestDeleteStaff> {
        #region 注入服务
        public StaffRep staffRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {

            var staff = new Staff() {
                StaffId = this.Parameter.StaffId
            };
            this.Result.Data = staffRep.Delete(staff);
        }
    }
}
