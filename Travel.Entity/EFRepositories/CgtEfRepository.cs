using Microsoft.EntityFrameworkCore;
using Travel.DDD.Domain;
using Travel.Entity.CGTModels;
using Travel.Repositories.EF;

namespace Travel.Entity.EFRepositories {
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
