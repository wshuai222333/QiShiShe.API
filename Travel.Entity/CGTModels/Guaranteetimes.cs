using System;
using System.Collections.Generic;

namespace QiShiShe.Entity.CGTModels
{
    public partial class Guaranteetimes
    {
        public int Id { get; set; }
        public long? UserId { get; set; }
        public string StepOneTime { get; set; }
        public string StepTwoTime { get; set; }
        public string StepThreeTime { get; set; }
        public string StepFourTime { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsRecharge { get; set; }
        public Guid? TableId { get; set; }
    }
}
