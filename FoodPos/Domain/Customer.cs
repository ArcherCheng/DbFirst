using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class Customer
    {
        public Customer()
        {
            Invoice = new HashSet<Invoice>();
            Questionnaire = new HashSet<Questionnaire>();
        }

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
        public int ComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Questionnaire> Questionnaire { get; set; }
    }
}
