using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class ViewQuestionnaireAnswerCountAll
    {
        public int? WriteComId { get; set; }
        public int? QuestionId { get; set; }
        public string QuestionDesc { get; set; }
        public int AnswerId { get; set; }
        public string AnswerDesc { get; set; }
        public int? AnswerCount { get; set; }
    }
}
