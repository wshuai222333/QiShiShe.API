using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Api.DTO.Boss.Request.Enterprise;
using QiShiShe.Api.Service.Boss;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Boss {
    [Produces("application/json")]
    [Route("api/Boss")]
    [EnableCors("AllowSameDomain")]
    public class EnterpriseController : BaseController {
        #region 注入服务
        public AddEnterpriseService addEnterpriseService { get; set; }

        public DeleteEnterpriseService deleteEnterpriseService { get; set; }

        public GetEnterpriseListService getEnterpriseListService { get; set; }

        public UpdateEnterpriseService updateEnterpriseService { get; set; }

        public GetEnterpriseListSelectService getEnterpriseListSelectService { get; set; }

        #endregion

        [Route("AddEnterprise"), HttpPost]
        public async Task<ResponseMessageModel> AddEnterprise([FromBody]RequestAddEnterprise model) {
            return await Task.Run(() => addEnterpriseService.Execute(model));
        }
        [Route("DeleteEnterprise"), HttpPost]
        public async Task<ResponseMessageModel> DeleteEnterprise([FromBody]RequestDeleteEnterprise model) {
            return await Task.Run(() => deleteEnterpriseService.Execute(model));
        }
        [Route("GetEnterpriseList"), HttpPost]
        public async Task<ResponseMessageModel> GetEnterpriseList([FromBody]RequestGetEnterpriseList model) {
            return await Task.Run(() => getEnterpriseListService.Execute(model));
        }
        [Route("GetEnterpriseListSelect"), HttpPost]
        public async Task<ResponseMessageModel> GetEnterpriseListSelect([FromBody]RequestGetEnterpriseListSelect model) {
            return await Task.Run(() => getEnterpriseListSelectService.Execute(model));
        }
        [Route("UpdateEnterprise"), HttpPost]
        public async Task<ResponseMessageModel> UpdateEnterprise([FromBody]RequestUpdateEnterprise model) {
            return await Task.Run(() => updateEnterpriseService.Execute(model));
        }
    }
}
