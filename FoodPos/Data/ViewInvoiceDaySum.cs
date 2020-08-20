using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class ViewInvoiceDaySum
    {
        public string InvoiceDate { get; set; }
        public int? InvoiceCounts { get; set; }
        public int? TotalOrderAmt { get; set; }
        public int? DiscountAmt { get; set; }
        public int? PromotionAmt { get; set; }
        public int? ServiceAmt { get; set; }
        public int? NetOrderAmt { get; set; }
    }
}
