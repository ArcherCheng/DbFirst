using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Sc1yer10
    {
        public string Syear { get; set; }
        public string EmpNo { get; set; }
        public decimal? YerScore { get; set; }
        public decimal? Add1score { get; set; }
        public decimal? Add2score { get; set; }
        public decimal? Add3score { get; set; }
        public decimal? NetScore { get; set; }
        public string NetLevel { get; set; }
        public string NetNote1 { get; set; }
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
        public decimal? Score11 { get; set; }
        public decimal? Score12 { get; set; }
        public decimal? TotScore { get; set; }
        public decimal? AvgScore { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
