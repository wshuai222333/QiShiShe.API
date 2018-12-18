using System;

namespace TravelCheckTicketForA.Service {
    /// <summary>
    /// A方验票接口请求参数
    /// </summary>
    public class CheckTicketRequestView {
        /// <summary>
        /// 公司编号
        /// </summary>
        public int CompanyId {
            get; set;
        }

        /// <summary>
        /// 票号
        /// </summary>
        public string TikcetNo {
            get; set;
        }

        /// <summary>
        /// 接口请求时间：格式  yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime RequestTime {
            get; set;
        }
    }

    /// <summary>
    /// A方验票接口返回参数
    /// </summary>
    public class CheckTicketResponseView {
        /// <summary>
        /// 是否成功 true： 成功   false： 失败
        /// </summary>
        public bool IsSuccess {
            get; set;
        }

        /// <summary>
        /// 成功时为验证结果，失败时是错误消息
        /// </summary>
        public string Message {
            get; set;
        }

    }
}
