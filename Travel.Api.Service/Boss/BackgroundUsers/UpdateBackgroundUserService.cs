using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class UpdateBackgroundUserService : ApiOriBase<RequestUpdateBackgroundUser> {
        #region 注入服务
        public BackgroundUserRep backgroundUserRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var backgroundUser = new BackgroundUser() {
                UserName = this.Parameter.UserName,
                UserPwd = Parameter.UserPwd,
                RealName = this.Parameter.RealName,
                UpdateTime = DateTime.Now
            };
            this.Result.Data = backgroundUserRep.UpdateBackgroundUser(backgroundUser);
        }
    }

}
