using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class ViewInvoiceSumByMonth
    {
        public int ComId { get; set; }
        public string GroupUnit { get; set; }
        public int? InvoiceCounts { get; set; }
        public int? TotalOrderAmt { get; set; }
        public int? AddonAmt { get; set; }
        public int? ServiceAmt { get; set; }
        public int? DiscountAmt { get; set; }
        public int? PromotionAmt { get; set; }
        public int? InvoiceAmt { get; set; }
    }
}
