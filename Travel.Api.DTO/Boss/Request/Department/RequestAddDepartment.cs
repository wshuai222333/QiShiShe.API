using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.Api.DTO.Boss.Request.Department {
    public class RequestAddDepartment : RequestOriBaseModel {
        public string DepartmentName { get; set; }

        public int EnterpriseId { get; set; }
    }
}
