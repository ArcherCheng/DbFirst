using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class OrderDetailAddon
    {
        public int Id { get; set; }
        public int DetailId { get; set; }
        public int AddonId { get; set; }
        public int ComId { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual FoodTypeAddon Addon { get; set; }
        public virtual OrderDetail Detail { get; set; }
    }
}
