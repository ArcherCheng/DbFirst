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
        public bool IsOnOff { get; set; }
        public int SortOrder { get; set; }
        public int ComId { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<OrderDetailAddon> OrderDetailAddon { get; set; }
    }
}
