using System;
using Travel.Api.DTO.CheckTicket.Request;
using Travel.Api.DTO.CheckTicket.Response;
using Travel.DDD.Logger;
using Travel.Entity.CGTLOGModels;
using TravelCheckTicketForA.Service;

namespace Travel.Api.Service.CheckTicket {
    public class CheckTicketService : ApiBase<RequestCheckTicket> {

        public CheckTicketForAProcessor checkTicketForAProcessor { get; set; }
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var checkTicketRequestView = new CheckTicketRequestView() {
                RequestTime = this.Parameter.RequestTime,
                TikcetNo = this.Parameter.TicketNumber
            };
            //调取票号数据
            checkTicketForAProcessor.Init(checkTicketRequestView);
            var execResult = checkTicketForAProcessor.Execute();

            #region  记录日志
            var _AliCheckTicketLog = new AliCheckTicketLog() {
                CreateTime = DateTime.Now,
                RequestTime = this.Parameter.RequestTime,
                ReturnMessage = "",
                ReturnResult = execResult.Message,
                ReturnTime = DateTime.Now,
                TikcetNo = this.Parameter.TicketNumber,
                IsSuccess = execResult.Success == false ? 0 : 1,
                MerchantId = model.MerchantId
            };
            aliCheckTicketLog.Insert(_AliCheckTicketLog);
            #endregion

            //返回票号结果
            if (execResult.Success) {
                this.Result.Data = CheckTicketForAMessageAnalysis(execResult.Message);
            } else {
                throw new AggregateException("查询失败！");
            }
        }


        /// <summary>
        /// 解析A方接口消息内容(去哪儿游)
        /// </summary>
        /// <param name="Message">接口返回消息</param>
        /// <param name="Name">姓名</param>
        /// <param name="Price">票价</param>
        public ResponseCheckTicket CheckTicketForAMessageAnalysis(string Message) {
            //"DETR TN784-2034099152,S\r\n\r\n航空公司电子客票航程通知单\r\n电子客票票号        784-2034099152\r\n后续客票号          NONE\r\n出票航空公司        MIS CAAC\r\n售票处信息          \r\n出票时间/地点       /<>\r\n旅客姓名            李杨\r\n身份识别号码        NONE\r\n票价    货币        CNY  金额   1090.00\r\n实付等值货币        CNY  金额   1090.00    付款方式 CA CASH(CNY)\r\n税款             CNY 50.00CN  CNY EXEMPTYQ\r\n付款总额            CNY 1140.00\r\n";
            try {
                //获取乘机人姓名
                int Name1 = Message.IndexOf("名"), Name2 = Message.IndexOf("身");
                if (Name2 <= Name1) {
                    Name2 = Message.LastIndexOf("身");
                }
                string name = Message.Substring(Name1 + 1, Name2 - Name1 - 1).Trim();
                //获取票面价
                int Price1 = Message.IndexOf("额"), Price2 = Message.IndexOf("实");
                if (Price2 <= Price1) {
                    Price2 = Message.LastIndexOf("实");
                }
                string price = Message.Substring(Price1 + 1, Price2 - Price1 - 1).Trim();
                //获取税款
                int PriceTax = Message.IndexOf("税款 "),PriceTax1 = Message.IndexOf("EXEMPTYQ");
                string tax = Message.Substring(PriceTax + 2, PriceTax1- PriceTax-7).Replace("CNY", "").Replace("CN","").Trim();
                //获取总价
                int Pricet = Message.IndexOf("付款总额");
                string totalprice = Message.Substring(Pricet + 4).Replace("CNY", "").Trim();
                return new ResponseCheckTicket { Name = name, Price = price, Tax = tax, TotalPrice = totalprice };

            } catch (Exception ex) {
                LoggerFactory.Instance.Logger_Debug("A方接口解析报错：" + ex.Message, "CheckTicketForAService");
                throw new AggregateException("接口解析失败！");
            }
        }


    }
}
