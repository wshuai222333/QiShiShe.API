using QiShiShe.Api.DTO.Boss.Request.Staff;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss {
    public class GetStaffListService : ApiOriBase<RequestGetStaffList> {
        #region 注入服务
        public StaffRep staffRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {

            var staff = new Staff() {
                EnterpriseId = this.Parameter.EnterpriseId,
                StaffName = this.Parameter.StaffName,
                StaffCardNo = this.Parameter.StaffCardNo,
                Phone = this.Parameter.Phone

            };
            this.Result.Data = staffRep.GetStaffList(this.Parameter.pageindex, this.Parameter.pagesize, staff);
        }

    }
}
