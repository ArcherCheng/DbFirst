using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class VWkChecksum1
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public string WkItem { get; set; }
        public decimal? SumWkQty { get; set; }
        public decimal? SumWkAmt { get; set; }
    }
}
