using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1set70
    {
        public string EatType { get; set; }
        public string EatNm { get; set; }
        public string Stime1 { get; set; }
        public string Stime2 { get; set; }
        public decimal EatAmt1 { get; set; }
        public decimal EatAmt2 { get; set; }
        public decimal EatAmtb1 { get; set; }
        public decimal EatAmtb2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
