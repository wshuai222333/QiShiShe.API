using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Enterprise.Request.Staff;
using QiShiShe.Api.Service.Enterprise;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Enterprise {
    [Produces("application/json")]
    [Route("api/Enterprise")]
    [EnableCors("AllowSameDomain")]
    public class StaffController : BaseController {
        #region 注入服务
        public StaffLoginService staffLoginService { get; set; }

        #endregion

        [Route("StaffLogin"), HttpPost]
        public async Task<ResponseMessageModel> StaffLogin([FromBody]RequestStaffLogin model) {
            return await Task.Run(() => staffLoginService.Execute(model));
        }
    }
}
