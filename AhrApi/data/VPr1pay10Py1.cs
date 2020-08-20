using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class VPr1pay10Py1
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public string EmpNm { get; set; }
        public string InDate { get; set; }
        public string OutDate { get; set; }
        public decimal PayAmt { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal PenAmt { get; set; }
    }
}
