using QiShiShe.Api.DTO.Boss.Request.AirInfo;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss {
    public class GetT_AirPortsListService : ApiOriBase<RequestGetT_AirPortsList> {
        #region 注入服务
        public T_AirPortsRep t_AirPortsRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            this.Result.Data = t_AirPortsRep.GetT_AirPortsList();
        }
    }
}
