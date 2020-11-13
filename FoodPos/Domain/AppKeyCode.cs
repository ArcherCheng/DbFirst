using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppKeyCode
    {
        public int Id { get; set; }
        public string AppCodeGroup { get; set; }
        public string AppCodeValue { get; set; }
        public string AppCodeLabel { get; set; }
        public int DisplayOrder { get; set; }
        public string Notes { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
