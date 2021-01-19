using System;
using System.Collections.Generic;

namespace FoodPos.Domain
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
        public int SortOrder { get; set; }
        public int SalePrice1 { get; set; }
        public int OffPrice1 { get; set; }
        public int SalePrice2 { get; set; }
        public int OffPrice2 { get; set; }
        public int SalePrice3 { get; set; }
        public int OffPrice3 { get; set; }
        public int PrepareMinutes { get; set; }
        public int CookMinutes { get; set; }
        public int CleanMinutes { get; set; }
        public bool IsMainFood { get; set; }
        public bool IsOnOff { get; set; }
        public string PicturePath { get; set; }
        public string Notes { get; set; }
        public int ComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<FoodOff> FoodOff { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
