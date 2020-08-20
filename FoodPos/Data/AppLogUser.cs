using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class AppLogUser
    {
        public long Id { get; set; }
        public string Refer { get; set; }
        public string Destination { get; set; }
        public string QueryString { get; set; }
        public string Method { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
