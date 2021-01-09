using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class ViewOrderDetail
    {
        public int? WriteComId { get; set; }
        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int Qty { get; set; }
        public int? SalePriceSum { get; set; }
        public int? OffPriceSum { get; set; }
        public int? AddonPriceSum { get; set; }
        public int DetailAmt { get; set; }
    }
}
