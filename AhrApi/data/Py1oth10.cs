using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Py1oth10
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public string TaxCd { get; set; }
        public string TaxFg { get; set; }
        public decimal? PayAmt { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? NetAmt { get; set; }
        public string Note1 { get; set; }
        public string ShareData1 { get; set; }
        public string ShareData2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Py1set10 TaxCdNavigation { get; set; }
        public virtual Py1set40 TaxFgNavigation { get; set; }
    }
}
