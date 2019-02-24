using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Enterprise.Request.Staff;
using QiShiShe.Api.Service;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Enterprise {
    [Produces("application/json")]
    [Route("api/Enterprise")]
    [EnableCors("AllowSameDomain")]
    public class StaffController : BaseController {
        #region 注入服务
        public StaffLoginService staffLoginService { get; set; }

        public GetStaffListService getStaffListService { get; set; }

        public GetStaffListChangeValueService getStaffListChangeValueService { get; set; }
        #endregion

        [Route("StaffLogin"), HttpPost]
        public async Task<ResponseMessageModel> StaffLogin([FromBody]RequestStaffLogin model) {
            return await Task.Run(() => staffLoginService.Execute(model));
        }
        [Route("GetStaffList"), HttpPost]
        public async Task<ResponseMessageModel> GetStaffList([FromBody]RequestGetStaffList model) {
            return await Task.Run(() => getStaffListService.Execute(model));
        }
        [Route("GetStaffListChangeValue"), HttpPost]
        public async Task<ResponseMessageModel> GetStaffListChangeValue([FromBody]RequestGetStaffList model)
        {
            return await Task.Run(() => getStaffListChangeValueService.Execute(model));
        }
    }
}
