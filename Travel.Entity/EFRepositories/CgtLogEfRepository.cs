using Microsoft.EntityFrameworkCore;
using Travel.DDD.Domain;
using Travel.Entity.CGTLOGModels;
using Travel.Repositories.EF;

namespace Travel.Entity.EFRepositories {
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
