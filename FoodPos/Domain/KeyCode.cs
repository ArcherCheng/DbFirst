using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class KeyCode
    {
        public int Id { get; set; }
        public string KeyCodeGroup { get; set; }
        public string KeyCodeValue { get; set; }
        public string KeyCodeLabel { get; set; }
        public int SortNo { get; set; }
        public string Notes { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
