﻿using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class DeleteEnterpriseService : ApiOriBase<RequestDeleteEnterprise> {
        #region 注入服务
        public EnterpriseRep enterpriseRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var enterprise = new Enterprise() {
                 EnterpriseId = this.Parameter.EnterpriseId
            };
            this.Result.Data = enterpriseRep.Delete(enterprise);
        }
    }
}
