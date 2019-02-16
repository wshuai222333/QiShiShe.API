using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss
{
    public class UpdateDemandOrderStatusService : ApiOriBase<RequestUpdateDemandOrderStatus>
    {
        #region 注入服务
        public DemandOrderRep demandOrderRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod()
        {
            this.Result.Data = demandOrderRep.UpdateDemandOrderStatus(this.Parameter.OrderId,this.Parameter.Status);
        }
    }
}
