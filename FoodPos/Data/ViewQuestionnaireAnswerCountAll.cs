﻿using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class ViewQuestionnaireAnswerCountAll
    {
        public int? QuestionId { get; set; }
        public string QuestionDesc { get; set; }
        public int AnswerId { get; set; }
        public string AnswerDesc { get; set; }
        public int? AnswerCount { get; set; }
    }
}
