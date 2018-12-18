using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class InterfaceAccountAndUserAccount
    {
        public long InterfaceAccountAndUserAccountId { get; set; }
        public string InterfaceName { get; set; }
        public string UserName { get; set; }
        public Guid? TableId { get; set; }
    }
}
