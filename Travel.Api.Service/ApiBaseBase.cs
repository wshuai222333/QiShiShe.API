using QiShiShe.Api.DTO;
using QiShiShe.Entity;

namespace QiShiShe.Api.Service {
    public abstract class ApiBaseBase<T> : DbBase,IApi<T> {
        /// <summary>
        /// 执行
        /// </summary>
        /// <returns></returns>
        public abstract ResponseMessageModel Execute(T t);
    }
}
