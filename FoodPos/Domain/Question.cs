using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class Question
    {
        public int QuestionId { get; set; }
        public string QuestionDesc { get; set; }
        public int SortOrder { get; set; }
        public bool IsOnOff { get; set; }
        public string Notes { get; set; }
        public int ComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }
    }
}
