using System;
using System.Linq;
using Travel.Api.DTO.BackTicket.Request;

namespace Travel.Api.Service.BackTicket {
    /// <summary>
    /// 放款回调接口
    /// </summary>
    public class BackTicketService : ApiBase<BackTicketRequest> {
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var orderid = this.Parameter.OrderId.Trim();
            var _aliEnterpriseOrder = aliEnterpriseOrder.GetModel(i => i.OrderId == orderid).FirstOrDefault();
            if (_aliEnterpriseOrder!=null) {
                _aliEnterpriseOrder.BackStatus = int.Parse(this.Parameter.BackStatus);
                _aliEnterpriseOrder.BackTime = this.Parameter.BackTime;
                _aliEnterpriseOrder.BackMessage = this.Parameter.BackMessage;
                var _aliEnterpriseOrderId = aliEnterpriseOrder.Update(_aliEnterpriseOrder);
                if (_aliEnterpriseOrderId>0) {
                    this.Result.Data = new { ReceiveStatus = "Success" };
                } else {
                    throw new AggregateException("更新订单失败！");
                }

            } else {
                throw new AggregateException("查询无此订单！");
            }
        }
    }
}
