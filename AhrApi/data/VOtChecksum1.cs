using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class VOtChecksum1
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public decimal? SumOtHr { get; set; }
        public decimal? SumOtAmt { get; set; }
        public decimal? SumOtAmt1 { get; set; }
        public decimal? SumOtAmt2 { get; set; }
        public decimal? SumDutyAmt { get; set; }
    }
}
