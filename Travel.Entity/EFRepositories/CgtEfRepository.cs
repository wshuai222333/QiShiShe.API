using Microsoft.EntityFrameworkCore;
using QiShiShe.DDD.Domain;
using QiShiShe.Entity.CGTModels;
using QiShiShe.Repositories.EF;

namespace QiShiShe.Entity.EFRepositories {
    /// <summary>
    /// cgt数据库
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CgtEfRepository<T> : EFRepository<T> where T : class, IEntity {
        public CgtEfRepository(DbContext db)
            : base(db ?? new cgtContext()) {
        }
    }
}
