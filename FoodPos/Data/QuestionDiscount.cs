using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class QuestionDiscount
    {
        public int Id { get; set; }
        public int MinAmount { get; set; }
        public int MaxAmount { get; set; }
        public string DiscountType { get; set; }
        public int DiscountAmt { get; set; }
        public bool IsOnOff { get; set; }
        public string Notes { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
