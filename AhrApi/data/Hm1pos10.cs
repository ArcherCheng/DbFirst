using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1pos10
    {
        public Hm1pos10()
        {
            Pr1sar10 = new HashSet<Pr1sar10>();
            Tn1new30 = new HashSet<Tn1new30>();
        }

        public string PosNo { get; set; }
        public string PosNm { get; set; }
        public string PosEng { get; set; }
        public decimal? PosLevel { get; set; }
        public string PosType { get; set; }
        public string PosAttr { get; set; }
        public decimal PosAmt { get; set; }
        public string PosNew { get; set; }
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

        public virtual ICollection<Pr1sar10> Pr1sar10 { get; set; }
        public virtual ICollection<Tn1new30> Tn1new30 { get; set; }
    }
}
