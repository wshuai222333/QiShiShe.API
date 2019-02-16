using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss
{
    public class GetSelectHotelListService : ApiOriBase<RequestGetSelectHotelList>
    {
        #region 注入服务
        public SelectHotelRep selectHotelRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod()
        {
             this.Result.Data = selectHotelRep.GetSelectHotelList(this.Parameter.OrderId);
        }
    }
}
