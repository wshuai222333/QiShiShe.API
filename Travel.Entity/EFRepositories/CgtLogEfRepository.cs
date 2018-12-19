using Microsoft.EntityFrameworkCore;
using QiShiShe.DDD.Domain;
using QiShiShe.Entity.CGTLOGModels;
using QiShiShe.Repositories.EF;

namespace QiShiShe.Entity.EFRepositories {
    /// <summary>
    /// cgt_log数据库
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CgtLogEfRepository<T> : EFRepository<T> where T : class, IEntity {
        public CgtLogEfRepository(DbContext db)
            : base(db ?? new cgt_logContext()) {
        }
    }
}
