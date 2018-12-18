using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class InsuranceCompany
    {
        public int InsuranceCompanyId { get; set; }
        public string CompanyName { get; set; }
        public decimal? InsuranceRate { get; set; }
        public decimal? InsuranceSubtract { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CreateName { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string ModifyName { get; set; }
        public string InsuranceCompanyCode { get; set; }
    }
}
