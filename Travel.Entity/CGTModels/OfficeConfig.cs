using System;
using System.Collections.Generic;

namespace Travel.Entity.CGTModels
{
    public partial class OfficeConfig
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public int? Type { get; set; }
        public string Eterm { get; set; }
        public string EtermPw { get; set; }
        public string OfficeNo { get; set; }
        public string Si { get; set; }
        public string ServerAddress { get; set; }
        public string Port { get; set; }
        public string B2bname { get; set; }
        public string B2bpw { get; set; }
    }
}
