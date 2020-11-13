using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class ViewCustomerOrderSum
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
        public string TelNo { get; set; }
        public string TaxNo { get; set; }
        public string Notes { get; set; }
        public int? OrderAmtAll { get; set; }
        public int? OrderAmt30D { get; set; }
    }
}
