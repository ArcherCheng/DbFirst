using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Lv6leav10
    {
        public string EmpNo { get; set; }
        public string Sdate1 { get; set; }
        public string Stime1 { get; set; }
        public string Sdate2 { get; set; }
        public string Stime2 { get; set; }
        public string Smon { get; set; }
        public string LvNo { get; set; }
        public decimal? LvHr { get; set; }
        public string Note1 { get; set; }
        public decimal LvAmt { get; set; }
        public decimal MealAmt { get; set; }
        public decimal DutyAmt { get; set; }
        public decimal OthAmt { get; set; }
        public string AdjYn { get; set; }
        public decimal? SubHr { get; set; }
        public decimal? LvLx { get; set; }
        public string ChkId1 { get; set; }
        public string ChkId2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
