﻿using QiShiShe.Api.DTO.Boss.Request.Staff;
using QiShiShe.Entity.Model;
using QiShiShe.PetaPoco.Repositories.QiShiShe;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.Service.Boss {
    public class AddStaffService : ApiOriBase<RequestAddStaff> {
        #region 注入服务
        public StaffRep staffRep { get; set; }
        #endregion
        /// <summary>
        /// 执行方法
        /// </summary>
        protected override void ExecuteMethod() {
            var staff = new Staff() {
                DepartmentId = this.Parameter.DepartmentId,
                EnterpriseId = this.Parameter.EnterpriseId,
                StaffBirthday = this.Parameter.StaffBirthday,
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                StaffCardNo = this.Parameter.StaffCardNo,
                StaffName = this.Parameter.StaffName,
                Status = 1,
                StaffId = this.Parameter.StaffId,
                EnterpriseName = this.Parameter.EnterpriseName,
                Integral = 0,
                UserName = this.Parameter.Phone,
                UserPwd = this.Parameter.StaffCardNo.Substring(this.Parameter.StaffCardNo.Length - 6, 6),
                Phone = this.Parameter.Phone
            };
            if (this.Parameter.StaffId > 0) {
                this.Result.Data = staffRep.UpdateStaff(staff);
            } else {
                this.Result.Data = staffRep.Insert(staff);
            }

        }
    }
}
