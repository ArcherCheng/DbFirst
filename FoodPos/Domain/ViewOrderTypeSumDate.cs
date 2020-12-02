using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class ViewOrderTypeSumDate
    {
        public string GroupUnit { get; set; }
        public string OrderType { get; set; }
        public int? OrderCounts { get; set; }
        public int? OrderAmt { get; set; }
        public int? SalePriceSum { get; set; }
        public int? OffPriceSum { get; set; }
        public int? AddonPriceSum { get; set; }
    }
}
