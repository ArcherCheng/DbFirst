using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class FoodOff
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int OffPrice { get; set; }
        public DateTime OffDate1 { get; set; }
        public DateTime OffDate2 { get; set; }
        public string Notes { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual Food Food { get; set; }
    }
}
