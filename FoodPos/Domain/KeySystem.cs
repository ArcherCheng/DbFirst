using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class KeySystem
    {
        public int Id { get; set; }
        public string KeySystemGroup { get; set; }
        public string KeySystemCode { get; set; }
        public string KeySystemValue { get; set; }
        public string KeySystemLabel { get; set; }
        public string Notes { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
