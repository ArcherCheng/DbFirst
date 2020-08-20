using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Sc1cod10
    {
        public string ScNo { get; set; }
        public string Cmon1 { get; set; }
        public string Cmon2 { get; set; }
        public string ScCode1 { get; set; }
        public string ScCode2 { get; set; }
        public string ScCode3 { get; set; }
        public string ScCode4 { get; set; }
        public string ScCode5 { get; set; }
        public string ScCode6 { get; set; }
        public string ScCode7 { get; set; }
        public string ScCode8 { get; set; }
        public string ScCode9 { get; set; }
        public string ScCode10 { get; set; }
        public string ScCode11 { get; set; }
        public decimal? ScScore1 { get; set; }
        public decimal? ScScore2 { get; set; }
        public decimal? ScScore3 { get; set; }
        public decimal? ScScore4 { get; set; }
        public decimal? ScScore5 { get; set; }
        public decimal? ScScore6 { get; set; }
        public decimal? ScScore7 { get; set; }
        public decimal? ScScore8 { get; set; }
        public decimal? ScScore9 { get; set; }
        public decimal? ScScore10 { get; set; }
        public decimal? ScScore11 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Sc1set10 ScNoNavigation { get; set; }
    }
}
