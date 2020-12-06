using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceAddon = new HashSet<InvoiceAddon>();
            OrderMaster = new HashSet<OrderMaster>();
        }

        public int InvoiceId { get; set; }
        public int TotalOrderAmt { get; set; }
        public string InvoiceNo1 { get; set; }
        public int InvoiceNo2 { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceBigMonth { get; set; }
        public int? CustomerId { get; set; }
        public string TaxNo { get; set; }
        public int? QuestionnaireId { get; set; }
        public int DiscountAmt { get; set; }
        public int? PromotionId { get; set; }
        public int PromotionAmt { get; set; }
        public int ServiceAmt { get; set; }
        public int AddonAmt { get; set; }
        public int NetOrderAmt { get; set; }
        public string Notes { get; set; }
        public bool IsDelete { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Promotion Promotion { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual ICollection<InvoiceAddon> InvoiceAddon { get; set; }
        public virtual ICollection<OrderMaster> OrderMaster { get; set; }
    }
}
