using Microsoft.AspNetCore.Http;

namespace QiShiShe.DDD.Utils.Http {
    public static class MyHttpContext {
        private static IHttpContextAccessor _accessor;

        public static Microsoft.AspNetCore.Http.HttpContext Current => _accessor.HttpContext;

        internal static void Configure(IHttpContextAccessor accessor) {
            _accessor = accessor;
        }
    }
}
