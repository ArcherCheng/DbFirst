using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class Question
    {
        public Question()
        {
            QuestionAnswer = new HashSet<QuestionAnswer>();
            QuestionnaireAnswer = new HashSet<QuestionnaireAnswer>();
        }

        public int QuestionId { get; set; }
        public string QuestionDesc { get; set; }
        public bool IsOnOff { get; set; }
        public int SortOrder { get; set; }
        public string Notes { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<QuestionAnswer> QuestionAnswer { get; set; }
        public virtual ICollection<QuestionnaireAnswer> QuestionnaireAnswer { get; set; }
    }
}
