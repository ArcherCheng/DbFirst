﻿using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class QuestionAnswer
    {
        public QuestionAnswer()
        {
            QuestionnaireAnswer = new HashSet<QuestionnaireAnswer>();
        }

        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int SortOrder { get; set; }
        public string AnswerDesc { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<QuestionnaireAnswer> QuestionnaireAnswer { get; set; }
    }
}
