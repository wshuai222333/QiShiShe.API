using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Api.Controllers {
    [Produces("application/json")]
    [Route("api/Test")]
    [EnableCors("AllowSameDomain")]
    public class TestController : Controller {
        [Route("test")]
        [HttpGet]
        public dynamic User() {
            string aaa = "接口显示测试页面";
            return new {
                aaa = aaa
            };
        }
    }
}
