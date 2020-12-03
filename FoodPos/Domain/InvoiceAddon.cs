using System;

namespace FoodPos.Domain
{
    public partial class InvoiceAddon
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int AddonId { get; set; }
        public int Qty { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual CheckoutAddon Addon { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
