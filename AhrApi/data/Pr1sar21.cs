using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Pr1sar21
    {
        public byte ScoreNo { get; set; }
        public decimal Score1 { get; set; }
        public decimal? Score2 { get; set; }
        public decimal Amt1 { get; set; }
        public decimal? Rate1 { get; set; }
        public byte? Level1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
