using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using QiShiShe.Api.DTO;
using QiShiShe.Api.Service.CheckTicket;

namespace QiShiShe.Api.Controllers.CheckTicket {
    /// <summary>
    /// 验票API
    /// </summary>
    [Produces("application/json")]
    [Route("api/CheckTicket")]
    [EnableCors("AllowSameDomain")]
    public class CheckTicketController : BaseController {
        #region 注入服务
        public CheckTicketService checkTicketService { get; set; }
        #endregion
        /// <summary>
        /// 验票
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("CheckTicket"), HttpPost]
        public async Task<ResponseMessageModel> CheckTicket([FromBody]RequestModel model) {
            return await Task.Run(() => checkTicketService.Execute(model));
        }
    }
}
