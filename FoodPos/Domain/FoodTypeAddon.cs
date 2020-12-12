using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class FoodTypeAddon
    {
        public FoodTypeAddon()
        {
            OrderDetailAddon = new HashSet<OrderDetailAddon>();
        }

        public int AddonId { get; set; }
        public string AddonType { get; set; }
        public string AddonName { get; set; }
        public int AddonPrice { get; set; }
        public bool IsSale { get; set; }
        public int SortNo { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<OrderDetailAddon> OrderDetailAddon { get; set; }
    }
}
