using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Api.Service.Boss;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Boss {

    [Produces("application/json")]
    [Route("api/BackTicket")]
    [EnableCors("AllowSameDomain")]
    public class BossController:BaseController {
        #region 注入服务
        public BackgroundUserLoginService backgroundUserLoginService { get; set; }
        #endregion
        /// <summary>
        /// 放款回调
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("BackgroundUserLogin"), HttpPost]
        public async Task<ResponseMessageModel> BackgroundUserLogin([FromBody]RequestBackgroundUserLogin model) {
            return await Task.Run(() => backgroundUserLoginService.Execute(model));
        }
    }
}
