using QiShiShe.Api.DTO.Boss.Request.Department;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class UpdateDepartmentService : ApiOriBase<RequestUpdateDepartment> {
        #region 注入服务
        public DepartmentRep enterpriseRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var department = new Department() {
                UpdateTime = DateTime.Now,
                DepartmentName = this.Parameter.DepartmentName,
                EnterpriseId = this.Parameter.EnterpriseId,
                DepartmentId = this.Parameter.DepartmentId
            };
            this.Result.Data = enterpriseRep.Update(department);
        }
    }
}
