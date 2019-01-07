using QiShiShe.Api.DTO.Boss.Request.Enterprise;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class GetEnterpriseListSelectService : ApiOriBase<RequestGetEnterpriseListSelect> {
        #region 注入服务
        public EnterpriseRep enterpriseRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {

            this.Result.Data = enterpriseRep.GetEnterpriseList();
        }
    }
}
