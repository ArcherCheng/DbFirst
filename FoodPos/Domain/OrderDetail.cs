using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            OrderDetailAddon = new HashSet<OrderDetailAddon>();
        }

        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public int Qty { get; set; }
        public int SalePrice { get; set; }
        public int OffPrice { get; set; }
        public int AddonPrice { get; set; }
        public int DetailAmt { get; set; }
        public int? SeatNo { get; set; }
        public int CookStep { get; set; }
        public bool IsCookOver { get; set; }
        public string CookUser { get; set; }
        public int ComId { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual Food Food { get; set; }
        public virtual OrderMaster Order { get; set; }
        public virtual ICollection<OrderDetailAddon> OrderDetailAddon { get; set; }
    }
}
