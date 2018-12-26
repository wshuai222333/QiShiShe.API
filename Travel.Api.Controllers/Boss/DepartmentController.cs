using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Boss.Request.Department;
using QiShiShe.Api.Service.Boss;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Boss {
    [Produces("application/json")]
    [Route("api/Boss")]
    [EnableCors("AllowSameDomain")]
    public class DepartmentController : BaseController {
        #region 注入服务
        public AddDepartmentService addDepartmentService { get; set; }

        public DeleteDepartmentService deleteDepartmentService { get; set; }

        public GetDepartmentListService getDepartmentListService { get; set; }

        public UpdateDepartmentService updateDepartmentService { get; set; }
        #endregion

        [Route("AddDepartment"), HttpPost]
        public async Task<ResponseMessageModel> AddDepartment([FromBody]RequestAddDepartment model) {
            return await Task.Run(() => addDepartmentService.Execute(model));
        }
        [Route("DeleteDepartment"), HttpPost]
        public async Task<ResponseMessageModel> DeleteDepartment([FromBody]RequestDeleteDepartment model) {
            return await Task.Run(() => deleteDepartmentService.Execute(model));
        }
        [Route("GetDepartmentList"), HttpPost]
        public async Task<ResponseMessageModel> GetDepartmentList([FromBody]RequestGetDepartmentList model) {
            return await Task.Run(() => getDepartmentListService.Execute(model));
        }
        [Route("UpdateDepartment"), HttpPost]
        public async Task<ResponseMessageModel> UpdateDepartment([FromBody]RequestUpdateDepartment model) {
            return await Task.Run(() => updateDepartmentService.Execute(model));
        }

    }
}
