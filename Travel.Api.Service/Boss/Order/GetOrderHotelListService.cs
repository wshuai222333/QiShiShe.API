using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss.Order
{
    public class GetOrderHotelListService : ApiOriBase<RequestGetSelectHotelList>
    {
        #region 注入服务
        public OrderHotelRep orderHotelRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod()
        {
            this.Result.Data = orderHotelRep.GetOrderHotelList(this.Parameter.OrderId);
        }
    }
}
