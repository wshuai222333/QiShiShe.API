﻿using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss
{
    public class GetOrderApartmentListService : ApiOriBase<RequestGetOrderPassengerList>
    {
        #region 注入服务
        public OrderApartmentRep orderApartmentRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod()
        {
            this.Result.Data = orderApartmentRep.GetOrderApartmentList(this.Parameter.OrderId);
        }
    }
}
