using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class VLvChecksum1
    {
        public string EmpNo { get; set; }
        public string Smon { get; set; }
        public decimal? SumLvHr { get; set; }
        public decimal? SumNetHr { get; set; }
        public decimal? SumLvAmt { get; set; }
        public decimal? SumMealAmt { get; set; }
        public decimal? SumDutyAmt { get; set; }
        public decimal? SumOthAmt { get; set; }
    }
}
