using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Boss.Request.Order;
using QiShiShe.Api.DTO.Enterprise.Request.Order;
using QiShiShe.Api.Service.Boss;
using QiShiShe.Api.Service.Boss.Order;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Boss {
    [Produces("application/json")]
    [Route("api/Boss")]
    [EnableCors("AllowSameDomain")]
    public class OrderController : BaseController {
        #region 注入服务
        public GetDemandOrderListByBossService getDemandOrderListByBossService { get; set; }

        public AddSelectAirTicketService addSelectAirTicketService { get; set; }

        public GetSelectAirTicketListService getSelectAirTicketListService { get; set; }
        public AddSelectTrainTicketService addSelectTrainTicketService { get; set; }

        public GetSelectTrainTicketListService getSelectTrainTicketListService { get; set; }

        public AddSelectHotelService addSelectHotelService { get; set; }

        public GetSelectHotelListService getSelectHotelListService { get; set; }
        public GetOrderPassengerListService getOrderPassengerListService { get; set; }
        public GetOrderApartmentListService getOrderApartmentListService { get; set; }

        public UpdateDemandOrderStatusService updateDemandOrderStatusService { get; set; }

        public GetOrderAirTicketListService getOrderAirTicketListService { get; set; }

        public GetOrderTrainTicketListService getOrderTrainTicketListService { get; set; }


        public GetOrderHotelListService getOrderHotelListService { get; set; }
        #endregion


        [Route("GetDemandOrderListByBoss"), HttpPost]
        public async Task<ResponseMessageModel> StaffLogin([FromBody]RequestGetDemandOrderListByBoss model) {
            return await Task.Run(() => getDemandOrderListByBossService.Execute(model));
        }
        [Route("AddSelectAirTicket"), HttpPost]
        public async Task<ResponseMessageModel> AddSelectAirTicket([FromBody]RequestAddSelectAirTicket model)
        {
            return await Task.Run(() => addSelectAirTicketService.Execute(model));
        }
        [Route("GetSelectAirTicketList"), HttpPost]
        public async Task<ResponseMessageModel> GetSelectAirTicketList([FromBody]RequestGetSelectAirTicketList model)
        {
            return await Task.Run(() => getSelectAirTicketListService.Execute(model));
        }
        [Route("AddSelectTrainTicket"), HttpPost]
        public async Task<ResponseMessageModel> AddSelectTrainTicket([FromBody]RequestAddSelectTrainTicket model)
        {
            return await Task.Run(() => addSelectTrainTicketService.Execute(model));
        }
        [Route("GetSelectTrainTicketList"), HttpPost]
        public async Task<ResponseMessageModel> GetSelectTrainTicketList([FromBody]RequestGetSelectTrainTicketList model)
        {
            return await Task.Run(() => getSelectTrainTicketListService.Execute(model));
        }
        [Route("AddSelectHotel"), HttpPost]
        public async Task<ResponseMessageModel> AddSelectHotel([FromBody]RequestAddSelectHotel model)
        {
            return await Task.Run(() => addSelectHotelService.Execute(model));
        }
        [Route("GetSelectHotelList"), HttpPost]
        public async Task<ResponseMessageModel> GetSelectHotelList([FromBody]RequestGetSelectHotelList model)
        {
            return await Task.Run(() => getSelectHotelListService.Execute(model));
        }
        [Route("GetOrderPassengerList"), HttpPost]
        public async Task<ResponseMessageModel> GetOrderPassengerList([FromBody]RequestGetOrderPassengerList model)
        {
            return await Task.Run(() => getOrderPassengerListService.Execute(model));
        }
        [Route("GetOrderApartmentList"), HttpPost]
        public async Task<ResponseMessageModel> GetOrderApartmentList([FromBody]RequestGetOrderPassengerList model)
        {
            return await Task.Run(() => getOrderApartmentListService.Execute(model));
        }
        [Route("UpdateDemandOrderStatus"), HttpPost]
        public async Task<ResponseMessageModel> UpdateDemandOrderStatus([FromBody]RequestUpdateDemandOrderStatus model)
        {
            return await Task.Run(() => updateDemandOrderStatusService.Execute(model));
        }
        [Route("GetOrderAirTicketList"), HttpPost]
        public async Task<ResponseMessageModel> GetOrderAirTicketList([FromBody]RequestGetSelectAirTicketList model)
        {
            return await Task.Run(() => getOrderAirTicketListService.Execute(model));
        }
        [Route("GetOrderTrainTicketList"), HttpPost]
        public async Task<ResponseMessageModel> GetOrderTrainTicketList([FromBody]RequestGetSelectTrainTicketList model)
        {
            return await Task.Run(() => getOrderTrainTicketListService.Execute(model));
        }
        [Route("GetOrderHotelList"), HttpPost]
        public async Task<ResponseMessageModel> GetOrderHotelList([FromBody]RequestGetSelectHotelList model)
        {
            return await Task.Run(() => getOrderHotelListService.Execute(model));
        }
    }
}
