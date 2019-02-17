using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

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
            
            if (this.Parameter.Status==1)
            {
                this.Result.Data = demandOrderRep.UpdateDemandOrderStatus(this.Parameter.OrderId, this.Parameter.Status);
            }
            else if (this.Parameter.Status == 5)
            {
                this.Result.Data = demandOrderRep.UpdateOverDemandOrderStatus(this.Parameter.OrderId, this.Parameter.Status);
            }
            else
            {
                throw new AggregateException("订单状态编码异常!");
            }
           
        }
    }
}
