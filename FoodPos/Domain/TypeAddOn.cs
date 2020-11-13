using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class TypeAddOn
    {
        public TypeAddOn()
        {
            OrderDetailAddOn = new HashSet<OrderDetailAddOn>();
        }

        public int AddOnId { get; set; }
        public string AddOnType { get; set; }
        public string AddOnName { get; set; }
        public int AddPrice { get; set; }
        public int DisplayOrder { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<OrderDetailAddOn> OrderDetailAddOn { get; set; }
    }
}
