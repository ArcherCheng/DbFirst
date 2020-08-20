using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1mon10
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public decimal InsAmt1a { get; set; }
        public decimal InsAmt1b { get; set; }
        public decimal InsAmt2a { get; set; }
        public decimal InsAmt2b { get; set; }
        public decimal InsAmt3 { get; set; }
        public decimal InsAmt4 { get; set; }
        public decimal HeaAmt1 { get; set; }
        public decimal HeaAmt2 { get; set; }
        public decimal HeaAmt3 { get; set; }
        public decimal? Pns { get; set; }
        public decimal PenAmt1 { get; set; }
        public decimal? Rate1 { get; set; }
        public decimal PenAmt2 { get; set; }
        public decimal? Rate2 { get; set; }
        public string AdjYn { get; set; }
        public string Note1 { get; set; }
        public decimal SumPenAmt1 { get; set; }
        public decimal SumPenAmt2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
