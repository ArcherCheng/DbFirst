using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Bn1bon10
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public string BnNo { get; set; }
        public string Sdate { get; set; }
        public string BnType { get; set; }
        public decimal? BnDays { get; set; }
        public decimal BnAmt1 { get; set; }
        public decimal BnAmt2 { get; set; }
        public decimal BnAmt3 { get; set; }
        public decimal BnAmt { get; set; }
        public decimal BnTax { get; set; }
        public decimal SubAmt { get; set; }
        public decimal NetAmt { get; set; }
        public string AdjYn { get; set; }
        public string Note1 { get; set; }
        public string TaxOver { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public decimal? SumAmt { get; set; }
        public decimal? HeaAmt1 { get; set; }
        public decimal? HeaAmt2 { get; set; }

        public virtual Bn1set10 BnNoNavigation { get; set; }
        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
