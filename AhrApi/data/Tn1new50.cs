using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tn1new50
    {
        public string EmpNo { get; set; }
        public string TnNo { get; set; }
        public string Sdate1 { get; set; }
        public string Stime1 { get; set; }
        public string Sdate2 { get; set; }
        public string Stime2 { get; set; }
        public decimal TnHr { get; set; }
        public decimal TnCost { get; set; }
        public decimal? TnScore { get; set; }
        public decimal? TnWeight { get; set; }
        public string TnMethod { get; set; }
        public string CorNo { get; set; }
        public string Teacher { get; set; }
        public string TnYn { get; set; }
        public string DocNo { get; set; }
        public string ActDate { get; set; }
        public string Note1 { get; set; }
        public int? EmailCnt { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Tn1set10 TnNoNavigation { get; set; }
    }
}
