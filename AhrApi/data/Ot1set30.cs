using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ot1set30
    {
        public string OverCd { get; set; }
        public decimal OtHr1 { get; set; }
        public decimal OtHr2 { get; set; }
        public string OtChoice { get; set; }
        public decimal OtAmt1 { get; set; }
        public decimal OtAmt2 { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
