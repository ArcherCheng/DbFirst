using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class CheckoutAddon
    {
        public CheckoutAddon()
        {
            InvoiceAddon = new HashSet<InvoiceAddon>();
        }

        public int AddonId { get; set; }
        public string AddonName { get; set; }
        public int AddonPrice { get; set; }
        public bool IsSale { get; set; }
        public int SortNo { get; set; }
        public int? WriteComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<InvoiceAddon> InvoiceAddon { get; set; }
    }
}
