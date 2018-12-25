using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;

namespace QiShiShe.Api.Service.Boss {
    public class AddEnterpriseService : ApiOriBase<RequestAddEnterprise> {
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
                CreateTIme = DateTime.Now
            };
            this.Result.Data = enterpriseRep.Insert(enterprise);
        }
    }
}
