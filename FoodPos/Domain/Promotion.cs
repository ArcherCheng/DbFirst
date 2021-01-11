using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class Promotion
    {
        public Promotion()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string PromotionType { get; set; }
        public int MinOrderAmt { get; set; }
        public int PromotionPrice { get; set; }
        public bool InOnOff { get; set; }
        public string Notes { get; set; }
        public int ComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
