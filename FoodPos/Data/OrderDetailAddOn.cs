using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class OrderDetailAddOn
    {
        public int Id { get; set; }
        public int DetailId { get; set; }
        public int AddOnId { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual TypeAddOn AddOn { get; set; }
        public virtual OrderDetail Detail { get; set; }
    }
}
