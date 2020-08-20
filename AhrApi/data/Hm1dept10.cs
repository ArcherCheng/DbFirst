using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1dept10
    {
        public Hm1dept10()
        {
            Pr1sar10 = new HashSet<Pr1sar10>();
            Tn1new20 = new HashSet<Tn1new20>();
        }

        public string DeptNo { get; set; }
        public string DeptNm { get; set; }
        public string DeptEng { get; set; }
        public string DeptEmp { get; set; }
        public string DeptUp { get; set; }
        public decimal? DeptLevel { get; set; }
        public decimal? DeptPns { get; set; }
        public decimal? DeptSeq { get; set; }
        public string DeptNew { get; set; }
        public decimal DeptAmt { get; set; }
        public decimal Amt1 { get; set; }
        public decimal? Rate1 { get; set; }
        public byte? Level1 { get; set; }
        public decimal Amt2 { get; set; }
        public decimal? Rate2 { get; set; }
        public decimal? Day2 { get; set; }
        public decimal? Score1 { get; set; }
        public decimal? Score2 { get; set; }
        public decimal? Score3 { get; set; }
        public decimal? Score4 { get; set; }
        public decimal? Score5 { get; set; }
        public decimal? Score6 { get; set; }
        public decimal? Score7 { get; set; }
        public decimal? Score8 { get; set; }
        public decimal? Score9 { get; set; }
        public decimal? Score10 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public int? HeaPns { get; set; }
        public decimal? HeaAmt1 { get; set; }
        public decimal? HeaAmt2 { get; set; }
        public string DeptCost { get; set; }

        public virtual ICollection<Pr1sar10> Pr1sar10 { get; set; }
        public virtual ICollection<Tn1new20> Tn1new20 { get; set; }
    }
}
