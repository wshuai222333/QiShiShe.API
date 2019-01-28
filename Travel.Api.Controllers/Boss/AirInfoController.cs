using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Boss.Request.AirInfo;
using QiShiShe.Api.Service.Boss;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Boss {

    [Produces("application/json")]
    [Route("api/Boss")]
    [EnableCors("AllowSameDomain")]
    public class AirInfoController : BaseController {
        #region 注入服务
        public GetT_AirPortsListService getT_AirPortsListService { get; set; }

        #endregion
        [Route("GetT_AirPortsList"), HttpPost]
        public async Task<ResponseMessageModel> GetT_AirPortsList([FromBody]RequestGetT_AirPortsList model) {
            return await Task.Run(() => getT_AirPortsListService.Execute(model));
        }
    }
}
