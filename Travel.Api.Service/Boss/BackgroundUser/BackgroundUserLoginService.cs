using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class BackgroundUserLoginService : ApiOriBase<RequestBackgroundUserLogin> {
        #region 注入服务
        public BackgroundUserRep backgroundUserRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var backgroundUser = new BackgroundUser() {
                UserName = this.Parameter.UserName,
                UserPwd = this.Parameter.UserPwd,
            };
            var user = backgroundUserRep.GetBackgroundUser(backgroundUser);
            if (user != null) {
                if (user.Status==1) {
                    this.Result.Data = user;
                } else {
                    throw new AggregateException("用户已被停用！");
                }
            }
            else {
                throw new AggregateException("用户名或密码不正确！");
            }

        }
    }
}
