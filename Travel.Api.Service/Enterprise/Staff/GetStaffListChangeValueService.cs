
using QiShiShe.Api.DTO.Enterprise.Request.Staff;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System.Collections.Generic;
using System.Linq;

namespace QiShiShe.Api.Service
{
    public class GetStaffListChangeValueService : ApiOriBase<RequestGetStaffList>
    {
        #region 注入服务
        public StaffRep staffRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod()
        {

            var staff = new Staff()
            {
                EnterpriseId = this.Parameter.EnterpriseId,
                StaffName = this.Parameter.StaffName,
                StaffCardNo = this.Parameter.StaffCardNo,
                Phone = this.Parameter.Phone

            };
            var list = staffRep.GetStaffList(staff);

            var returnList = new List<StaffListChange>();
            foreach (var item in list)
            {
                var sc = new StaffListChange()
                {
                    cardno = item.StaffCardNo,
                    value = item.StaffName
                };
                returnList.Add(sc);
            }

            this.Result.Data = returnList;
        }

        public class StaffListChange
        {
            public string value { get; set; }

            public string cardno { get; set; }
        }
    }
}
