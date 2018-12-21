using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;

namespace QiShiShe.Api.Service.Boss {
    public class GetBackgroundUserService : ApiOriBase<RequestGetBackgroundUser> {
        #region 注入服务
        public BackgroundUserRep backgroundUserRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var backgroundUser = new BackgroundUser() {
                BackgroundUserId = this.Parameter.BackgroundUserId
            };
            this.Result.Data = backgroundUserRep.GetBackgroundUser(backgroundUser);
        }
    }
}
