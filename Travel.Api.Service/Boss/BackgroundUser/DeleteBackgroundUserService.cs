﻿using QiShiShe.Api.DTO.Boss.Request.BackgroundUsers;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class DeleteBackgroundUserService : ApiOriBase<RequestDeleteBackgroundUser> {
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
            this.Result.Data = backgroundUserRep.Insert(backgroundUser);
        }
    }
}
