using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Bn1bon60
    {
        public string EmpNo { get; set; }
        public string BnNo { get; set; }
        public string Smon { get; set; }
        public string BnkNo { get; set; }
        public string BnkAccp { get; set; }
        public decimal BnAmt1 { get; set; }
        public decimal BnAmt2 { get; set; }
        public decimal BnAmt3 { get; set; }
        public decimal BnAmt { get; set; }
        public decimal BnTax { get; set; }
        public decimal SubAmt { get; set; }
        public decimal NetAmt { get; set; }
        public string Note1 { get; set; }
        public decimal? SumAmt { get; set; }
        public decimal? HeaAmt1 { get; set; }
        public decimal? HeaAmt2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
