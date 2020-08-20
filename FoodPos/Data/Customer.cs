using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string TaxNo { get; set; }
        public string PostNo { get; set; }
        public string Address { get; set; }
        public string Contactor { get; set; }
        public string Notes { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
