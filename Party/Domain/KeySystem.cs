using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class KeySystem
    {
        public int Id { get; set; }
        public string SystemGroup { get; set; }
        public string SystemKey { get; set; }
        public string SystemValue { get; set; }
        public string SystemLabel { get; set; }
        public string Notes { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
