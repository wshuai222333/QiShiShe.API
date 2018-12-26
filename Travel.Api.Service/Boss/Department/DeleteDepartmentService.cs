using QiShiShe.Api.DTO.Boss.Request.Department;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class DeleteDepartmentService : ApiOriBase<RequestDeleteDepartment> {
        #region 注入服务
        public DepartmentRep enterpriseRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var department = new Department() {
                DepartmentId = this.Parameter.DepartmentId
            };
            this.Result.Data = enterpriseRep.Delete(department);
        }
    }
}
