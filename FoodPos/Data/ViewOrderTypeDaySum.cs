using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class ViewOrderTypeDaySum
    {
        public string OrderDate { get; set; }
        public string OrderType { get; set; }
        public int? OrderCounts { get; set; }
        public int? TotalDetailAmt { get; set; }
        public int? InvoiceCounts { get; set; }
        public int? TotalOrderAmt { get; set; }
        public int? DiscountAmt { get; set; }
        public int? PromotionAmt { get; set; }
        public int? ServiceAmt { get; set; }
        public int? NetOrderAmt { get; set; }
    }
}
