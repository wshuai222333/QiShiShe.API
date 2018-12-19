using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using QiShiShe.DDD.Domain;
using QiShiShe.Entity.CGTALIModels;
using QiShiShe.Repositories.EF;

namespace QiShiShe.Entity.EFRepositories
{
    /// <summary>
    /// cgt_ali数据库
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CgtAliEfRepository<T> : EFRepository<T> where T : class, IEntity {
        public CgtAliEfRepository(DbContext db)
            : base(db ?? new cgt_aliContext()) {
        }
    }
}
