using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class Food
    {
        public Food()
        {
            FoodOff = new HashSet<FoodOff>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public string Unit { get; set; }
        public int SortSeq { get; set; }
        public int CostPrice { get; set; }
        public int SalePrice { get; set; }
        public int OffPrice { get; set; }
        public int PrepareMinutes { get; set; }
        public int CookMinutes { get; set; }
        public int CleanMinutes { get; set; }
        public bool IsMainFood { get; set; }
        public bool InSale { get; set; }
        public string PictureUrl1 { get; set; }
        public string PictureUrl2 { get; set; }
        public string Notes { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<FoodOff> FoodOff { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
