using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class AddSelectHotelService : ApiOriBase<RequestAddSelectHotel> {
        #region 注入服务
        public SelectHotelRep selectHotelRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        protected override void ExecuteMethod() {
            var selectHotel = new SelectHotel() {
                CreateTime = DateTime.Now,
                HotelAddress = this.Parameter.HotelAddress,
                HotelName = this.Parameter.HotelName,
                OrderId = this.Parameter.OrderId,
                TotalPrice = this.Parameter.TotalPrice,
                HotelRules = this.Parameter.HotelRules

            };
            this.Result.Data = selectHotelRep.Insert(selectHotel);
        }
    }
}
