using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class QuestionAnswer
    {
        public QuestionAnswer()
        {
            QuestionnaireAnswer = new HashSet<QuestionnaireAnswer>();
        }

        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerDesc { get; set; }
        public int SortOrder { get; set; }
        public int ComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<QuestionnaireAnswer> QuestionnaireAnswer { get; set; }
    }
}
