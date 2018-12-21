using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QiShiShe.Api.DTO;
using QiShiShe.Api.DTO.Boss.Request;
using QiShiShe.Api.Service.Boss;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QiShiShe.Api.Controllers.Boss {

    [Produces("application/json")]
    [Route("api/Boss")]
    [EnableCors("AllowSameDomain")]
    public class BossController:BaseController {
        #region 注入服务
        public BackgroundUserLoginService backgroundUserLoginService { get; set; }

        public AddBackgroundUserService addBackgroundUserService { get; set; }

        public UpdateBackgroundUserService updateBackgroundUserService { get; set; }

        public GetBackgroundUserService getBackgroundUserService { get; set; }

        public GetBackgroundUserListService getBackgroundUserListService { get; set; }
        #endregion
      
        [Route("BackgroundUserLogin"), HttpPost]
        public async Task<ResponseMessageModel> BackgroundUserLogin([FromBody]RequestBackgroundUserLogin model) {
            return await Task.Run(() => backgroundUserLoginService.Execute(model));
        }
        [Route("AddBackgroundUser"), HttpPost]
        public async Task<ResponseMessageModel> AddBackgroundUser([FromBody]RequestAddBackgroundUser model) {
            return await Task.Run(() => addBackgroundUserService.Execute(model));
        }
        [Route("UpdateBackgroundUser"), HttpPost]
        public async Task<ResponseMessageModel> UpdateBackgroundUser([FromBody]RequestUpdateBackgroundUser model) {
            return await Task.Run(() => updateBackgroundUserService.Execute(model));
        }
        [Route("GetBackgroundUser"), HttpPost]
        public async Task<ResponseMessageModel> GetBackgroundUser([FromBody]RequestGetBackgroundUser model) {
            return await Task.Run(() => getBackgroundUserService.Execute(model));
        }
        [Route("GetBackgroundUserList"), HttpPost]
        public async Task<ResponseMessageModel> GetBackgroundUserList([FromBody]RequestGetBackgroundUserList model) {
            return await Task.Run(() => getBackgroundUserListService.Execute(model));
        }

    }
}
