using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Bn1bon41
    {
        public decimal Score1 { get; set; }
        public decimal? Score2 { get; set; }
        public decimal Amt2 { get; set; }
        public decimal? Day2 { get; set; }
        public decimal? Rate2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
