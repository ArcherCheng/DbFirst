using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class QuestionnaireAnswer
    {
        public int Id { get; set; }
        public int QuestionnaireId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int? WriteComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual QuestionAnswer Answer { get; set; }
        public virtual Question Question { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
    }
}
