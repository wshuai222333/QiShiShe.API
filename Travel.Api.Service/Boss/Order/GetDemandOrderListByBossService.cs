using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss {
    public class GetDemandOrderListByBossService : ApiOriBase<RequestGetDemandOrderListByBoss> {
        #region 注入服务
        public DemandOrderRep demandOrderRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod() {
            this.Result.Data = demandOrderRep.GetEnterpriseListByBoss(this.Parameter.pageindex, this.Parameter.pagesize);
        }
    }
}
