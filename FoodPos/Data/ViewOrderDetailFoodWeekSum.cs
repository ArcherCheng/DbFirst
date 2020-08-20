using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class ViewOrderDetailFoodWeekSum
    {
        public int? Week { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int? FoodCounts { get; set; }
    }
}
