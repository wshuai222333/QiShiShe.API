using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.Api.Service.Boss;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Boss {
    [Produces("application/json")]
    [Route("api/Boss")]
    [EnableCors("AllowSameDomain")]
    public class OrderController : BaseController {
        #region 注入服务
        public GetDemandOrderListByBossService getDemandOrderListByBossService { get; set; }


        #endregion


        [Route("GetDemandOrderListByBoss"), HttpPost]
        public async Task<ResponseMessageModel> StaffLogin([FromBody]RequestGetDemandOrderListByBoss model) {
            return await Task.Run(() => getDemandOrderListByBossService.Execute(model));
        }
    }
}
