using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss {
    public class GetBackgroundUserListService : ApiOriBase<RequestGetBackgroundUserList> {
        #region 注入服务
        public BackgroundUserRep backgroundUserRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            this.Result.Data = backgroundUserRep.GetBackgroundUserList(this.Parameter.pageindex,this.Parameter.pagesize);
        }
    }
}
