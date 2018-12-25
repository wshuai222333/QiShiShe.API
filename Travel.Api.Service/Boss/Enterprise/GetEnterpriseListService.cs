using QiShiShe.Api.DTO.Boss.Request.Enterprise;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class GetEnterpriseListService : ApiOriBase<RequestGetEnterpriseList> {
        #region 注入服务
        public EnterpriseRep enterpriseRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            
            this.Result.Data = enterpriseRep.GetEnterpriseList(this.Parameter.pageindex,this.Parameter.pagesize);
        }

    }
}
