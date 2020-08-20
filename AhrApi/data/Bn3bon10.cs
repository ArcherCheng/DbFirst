using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Bn3bon10
    {
        public string PrKeys { get; set; }
        public string PrKey1 { get; set; }
        public string PrKey2 { get; set; }
        public string PrKeynote1 { get; set; }
        public string PrKeynote2 { get; set; }
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public string Nation12 { get; set; }
        public string Sex { get; set; }
        public string DeptNo { get; set; }
        public string PosNo { get; set; }
        public string SchNo { get; set; }
        public string SarType { get; set; }
        public string SarAttr { get; set; }
        public string SarCost { get; set; }
        public string SarKind { get; set; }
        public string SarLevel { get; set; }
        public decimal? Pns { get; set; }
        public string BnNo { get; set; }
        public decimal? BnDays { get; set; }
        public decimal BnAmt1 { get; set; }
        public decimal BnAmt2 { get; set; }
        public decimal BnAmt3 { get; set; }
        public decimal BnAmt { get; set; }
        public decimal BnTax { get; set; }
        public decimal SubAmt { get; set; }
        public decimal NetAmt { get; set; }
        public decimal SumAmt { get; set; }
        public decimal HeaAmt1 { get; set; }
        public decimal HeaAmt2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
