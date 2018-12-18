using Travel.Api.DTO;
using Travel.Entity;

namespace Travel.Api.Service {
    public abstract class ApiBaseBase<T> : DbBase,IApi<T> {
        /// <summary>
        /// 执行
        /// </summary>
        /// <returns></returns>
        public abstract ResponseMessageModel Execute(T t);
    }
}
