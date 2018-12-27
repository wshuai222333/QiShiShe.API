using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class AddBackgroundUserService : ApiOriBase<RequestAddBackgroundUser> {
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
                RealName = this.Parameter.RealName,
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                Status = 1,
                BackgroundUserId = this.Parameter.BackgroundUserId
            };
            if (this.Parameter.BackgroundUserId > 0) {
                this.Result.Data = backgroundUserRep.UpdateBackgroundUser(backgroundUser);
            } else {
                this.Result.Data = backgroundUserRep.Insert(backgroundUser);
            }

        }
    }
}
