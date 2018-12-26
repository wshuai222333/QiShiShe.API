using QiShiShe.Api.DTO.Boss.Request.Department;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class AddDepartmentService : ApiOriBase<RequestAddDepartment> {
        #region 注入服务
        public DepartmentRep enterpriseRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var department = new Department() {
                CreateTime = DateTime.Now,
                DepartmentName = this.Parameter.DepartmentName,
                EnterpriseId = this.Parameter.EnterpriseId
            };
            this.Result.Data = enterpriseRep.Insert(department);
        }
    }
}
