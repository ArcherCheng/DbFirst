using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph3mon10
    {
        public string PkKeys { get; set; }
        public string PkKey1 { get; set; }
        public string PkKey2 { get; set; }
        public string PkKeynote1 { get; set; }
        public string PkKeynote2 { get; set; }
        public decimal? Pns { get; set; }
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public decimal InsAmt1a { get; set; }
        public decimal InsAmt1b { get; set; }
        public decimal InsAmt2a { get; set; }
        public decimal InsAmt2b { get; set; }
        public decimal InsAmt3 { get; set; }
        public decimal InsAmt4 { get; set; }
        public decimal HeaAmt1 { get; set; }
        public decimal HeaAmt2 { get; set; }
        public decimal HeaAmt3 { get; set; }
        public decimal PenAmt1 { get; set; }
        public decimal PenAmt2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
