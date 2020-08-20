using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class AppKeySystem
    {
        public int Id { get; set; }
        public string AppSysGroup { get; set; }
        public string AppSysKey { get; set; }
        public string AppSysValue { get; set; }
        public string AppSysLabel { get; set; }
        public string Notes { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
