using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Api.Service;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Enterprise
{
    [Produces("application/json")]
    [Route("api/Enterprise")]
    [EnableCors("AllowSameDomain")]
    public class OrderController : BaseController {
        #region 注入服务
        public GenerateOrderService generateOrderService { get; set; }

        public GetDemandOrderListService getDemandOrderListService { get; set; }

        public GetSelectAirTicketTopService getSelectAirTicketTopService { get; set; }
        #endregion

        [Route("GenerateOrder"), HttpPost]
        public async Task<ResponseMessageModel> StaffLogin([FromBody]RequestGenerateOrder model) {
            return await Task.Run(() => generateOrderService.Execute(model));
        }
        [Route("GetDemandOrderList"), HttpPost]
        public async Task<ResponseMessageModel> GetDemandOrderList([FromBody]RequestGetDemandOrderList model) {
            return await Task.Run(() => getDemandOrderListService.Execute(model));
        }
        [Route("GetSelectAirTicketTop"), HttpPost]
        public async Task<ResponseMessageModel> GetSelectAirTicketTop([FromBody]RequestGetSelectAirTicketList model)
        {
            return await Task.Run(() => getSelectAirTicketTopService.Execute(model));
        }

    }
}
