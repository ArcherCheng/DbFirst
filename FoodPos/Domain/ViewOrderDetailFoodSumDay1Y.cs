using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class ViewOrderDetailFoodSumDay1Y
    {
        public int? GroupUnit { get; set; }
        public int FoodId { get; set; }
        public string FoodType { get; set; }
        public string FoodName { get; set; }
        public int? SumQty { get; set; }
        public int? DetailAmtSum { get; set; }
        public int? SalePriceSum { get; set; }
        public int? OffPriceSum { get; set; }
        public int? AddOnPriceSum { get; set; }
    }
}
