using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class Questionnaire
    {
        public Questionnaire()
        {
            QuestionnaireAnswer = new HashSet<QuestionnaireAnswer>();
        }

        public int QuestionnaireId { get; set; }
        public string DiscountGuid { get; set; }
        public DateTime DiscountDate { get; set; }
        public string DiscountType { get; set; }
        public int DiscountAmt { get; set; }
        public string Suggestion { get; set; }
        public int InvoiceId { get; set; }
        public int? CustomerId { get; set; }
        public bool IsCashed { get; set; }
        public int ComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual ICollection<QuestionnaireAnswer> QuestionnaireAnswer { get; set; }
    }
}
