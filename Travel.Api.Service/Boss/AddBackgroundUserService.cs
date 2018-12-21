using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

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
                CreateTime = DateTime.Now
            };
            this.Result.Data = backgroundUserRep.Insert(backgroundUser);
        }
    }
}
