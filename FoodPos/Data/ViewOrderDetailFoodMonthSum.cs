using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class ViewOrderDetailFoodMonthSum
    {
        public string OrderMonth { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int? FoodCounts { get; set; }
    }
}
