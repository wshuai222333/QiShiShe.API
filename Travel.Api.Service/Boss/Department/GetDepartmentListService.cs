using QiShiShe.Api.DTO.Boss.Request.Department;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss {
    public class GetDepartmentListService : ApiOriBase<RequestGetDepartmentList> {
        #region 注入服务
        public DepartmentRep enterpriseRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var department = new Department() {
                 EnterpriseId = this.Parameter.EnterpriseId
            };
            this.Result.Data = enterpriseRep.GetDepartmentList(department,this.Parameter.pageindex,this.Parameter.pagesize);
        }
    }
}
