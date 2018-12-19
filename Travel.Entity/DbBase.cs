using QiShiShe.DDD.IRepositories;
using QiShiShe.Entity.CGTALIModels;
using QiShiShe.Entity.CGTLOGModels;
using QiShiShe.Entity.CGTModels;
using QiShiShe.Entity.EFRepositories;

namespace QiShiShe.Entity {
    /// <summary>
    /// 数据库连接
    /// </summary>
    public class DbBase {
        #region cgt数据库
        protected readonly cgtContext db;


        public readonly IExtensionRepository<InterfaceAccount> interfaceAccount;

        #endregion

        #region 日志
        protected readonly cgt_logContext cgtLogContext;
        public readonly IExtensionRepository<AliCheckTicketLog> aliCheckTicketLog;


        #endregion

        #region 阿里
        protected readonly cgt_aliContext cgt_aliContext;
        public readonly IExtensionRepository<AliEnterpriseOrder> aliEnterpriseOrder;


        #endregion

        /// <summary>
        /// 构造方法
        /// </summary>
        public DbBase() {
            #region cgt数据库
            db = new cgtContext();

           
            interfaceAccount = new CgtEfRepository<InterfaceAccount>(db);

            #endregion
            #region cgt_log日志库
            var cgtLogdb = new cgt_logContext();

            aliCheckTicketLog = new CgtLogEfRepository<AliCheckTicketLog>(cgtLogContext);


            #endregion

            #region cgt_ali日志库
            var cgtAlidb = new cgt_aliContext();

            aliEnterpriseOrder = new CgtAliEfRepository<AliEnterpriseOrder>(cgt_aliContext);


            #endregion
        }
    }
}
