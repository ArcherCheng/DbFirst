using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class KeyCode
    {
        public int Id { get; set; }
        public string CodeGroup { get; set; }
        public string CodeValue { get; set; }
        public string CodeLabel { get; set; }
        public int SortNo { get; set; }
        public string Notes { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
