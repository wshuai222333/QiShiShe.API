using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Boss.Request.Staff;
using QiShiShe.Api.Service.Boss;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Boss {
    [Produces("application/json")]
    [Route("api/Boss")]
    [EnableCors("AllowSameDomain")]
    public class StaffController:BaseController {
        #region 注入服务
        public AddStaffService addStaffService { get; set; }

        public DeleteStaffService deleteStaffService { get; set; }

        public GetStaffListService getStaffListService { get; set; }

        public UpdateStaffService updateStaffService { get; set; }

        public UpdateStaffIntegralService updateStaffIntegralService { get; set;}

        #endregion

        [Route("AddStaff"), HttpPost]
        public async Task<ResponseMessageModel> AddStaff([FromBody]RequestAddStaff model) {
            return await Task.Run(() => addStaffService.Execute(model));
        }
        [Route("DeleteStaff"), HttpPost]
        public async Task<ResponseMessageModel> DeleteStaff([FromBody]RequestDeleteStaff model) {
            return await Task.Run(() => deleteStaffService.Execute(model));
        }
        [Route("GetStaffList"), HttpPost]
        public async Task<ResponseMessageModel> GetStaffList([FromBody]RequestGetStaffList model) {
            return await Task.Run(() => getStaffListService.Execute(model));
        }
        [Route("UpdateStaff"), HttpPost]
        public async Task<ResponseMessageModel> UpdateStaff([FromBody]RequestUpdateStaff model) {
            return await Task.Run(() => updateStaffService.Execute(model));
        }
        [Route("UpdateStaffIntegral"), HttpPost]
        public async Task<ResponseMessageModel> UpdateStaffIntegral([FromBody]RequestUpdateStaffIntegral model) {
            return await Task.Run(() => updateStaffIntegralService.Execute(model));
        }
    }
}
