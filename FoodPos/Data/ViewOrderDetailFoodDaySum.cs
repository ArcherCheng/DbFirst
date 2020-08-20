using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class ViewOrderDetailFoodDaySum
    {
        public string OrderDate { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int? FoodCounts { get; set; }
    }
}
