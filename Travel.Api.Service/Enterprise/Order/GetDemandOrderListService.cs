using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service{
    public class GetDemandOrderListService : ApiOriBase<RequestGetDemandOrderList> {
        #region 注入服务
        public DemandOrderRep demandOrderRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod() {
            this.Result.Data = demandOrderRep.GetEnterpriseList(this.Parameter.EnterpriseId, this.Parameter.pageindex, this.Parameter.pagesize);
        }
    }
}
