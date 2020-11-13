using System;
using System.Collections.Generic;

namespace FoodPos.Domain
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
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
