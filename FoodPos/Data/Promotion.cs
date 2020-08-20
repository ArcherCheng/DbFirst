﻿using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class Promotion
    {
        public int PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string PromotionType { get; set; }
        public int MinOrderAmt { get; set; }
        public int PromotionPrice { get; set; }
        public bool InUse { get; set; }
        public string Notes { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
