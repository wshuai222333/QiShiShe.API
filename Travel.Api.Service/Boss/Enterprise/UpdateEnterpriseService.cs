using QiShiShe.Api.DTO.Boss.Request.Enterprise;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class UpdateEnterpriseService : ApiOriBase<RequestUpdateEnterprise> {
        #region 注入服务
        public EnterpriseRep enterpriseRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var enterprise = new Enterprise() {
                ContactsEmail = this.Parameter.ContactsEmail,
                ContactsName = this.Parameter.ContactsName,
                ContactsPhone = this.Parameter.ContactsPhone,
                EnterpriseName = this.Parameter.EnterpriseName,
                EnterpriseCode = this.Parameter.EnterpriseCode,
                UpdateTime = DateTime.Now
            };
            this.Result.Data = enterpriseRep.Insert(enterprise);
            this.Result.Data = enterpriseRep.UpdateEnterprise(enterprise);
        }
    }
}
