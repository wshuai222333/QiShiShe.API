using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using QiShiShe.Api.DTO;
using QiShiShe.Api.Service.BackTicket;

namespace QiShiShe.Api.Controllers.BackTicket {
    /// <summary>
    /// 放款回调API
    /// </summary>
    [Produces("application/json")]
    [Route("api/BackTicket")]
    [EnableCors("AllowSameDomain")]
    public class BackTicketController: BaseController {
        #region 注入服务
        public BackTicketService backTicketService { get; set; }
        #endregion
        /// <summary>
        /// 放款回调
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("BackTicket"), HttpPost]
        public async Task<ResponseMessageModel> BackTicket([FromBody]RequestModel model) {
            return await Task.Run(() => backTicketService.Execute(model));
        }
    }
}
