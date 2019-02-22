using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class DeleteSelectHotelService : ApiOriBase<RequestDeleteSelectHotel> {
        #region 注入服务
        public SelectHotelRep selectHotelRep { get; set; }
        #endregion

        protected override void ExecuteMethod() {
            var selectHotel = new SelectHotel() {
                 SelectHotelId = this.Parameter.SelectHotelId
            };
            this.Result.Data = selectHotelRep.Delete(selectHotel);
        }
    }
}
