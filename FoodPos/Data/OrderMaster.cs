using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class OrderMaster
    {
        public OrderMaster()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderType { get; set; }
        public int OrderPeoples { get; set; }
        public int TakeNo { get; set; }
        public int TableNo { get; set; }
        public int TotalDetailAmt { get; set; }
        public string Notes { get; set; }
        public int? InvoiceId { get; set; }
        public int OrderStep { get; set; }
        public bool IsCookOver { get; set; }
        public bool IsCheckout { get; set; }
        public string StoreName { get; set; }
        public string DutyNo { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
