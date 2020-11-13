using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class ViewCustomerDiscount
    {
        public int QuestionnaireId { get; set; }
        public string DiscountGuid { get; set; }
        public string DiscountType { get; set; }
        public int DiscountAmt { get; set; }
        public DateTime DiscountDate { get; set; }
        public int? CustomerId { get; set; }
    }
}
