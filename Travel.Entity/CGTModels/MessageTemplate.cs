using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class MessageTemplate
    {
        public int Id { get; set; }
        public int? BusinessType { get; set; }
        public int? StepType { get; set; }
        public string TemplateContent { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? OperationUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? TableId { get; set; }
    }
}
