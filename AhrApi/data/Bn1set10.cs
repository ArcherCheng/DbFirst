using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Bn1set10
    {
        public Bn1set10()
        {
            Bn1bon10 = new HashSet<Bn1bon10>();
        }

        public string BnNo { get; set; }
        public string BnNm { get; set; }
        public string BnType { get; set; }
        public string TaxCd { get; set; }
        public decimal? BnRate1 { get; set; }
        public decimal? BnRate2 { get; set; }
        public decimal BnTax1 { get; set; }
        public decimal BnTax2 { get; set; }
        public string BnBase { get; set; }
        public string BnCol1 { get; set; }
        public string BnCol2 { get; set; }
        public string BnCol3 { get; set; }
        public string BnHead1 { get; set; }
        public string BnHead2 { get; set; }
        public string BnHead3 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public string TaxFg { get; set; }
        public string HealthYn { get; set; }

        public virtual Pr1set10 BnCol1Navigation { get; set; }
        public virtual Py1set10 TaxCdNavigation { get; set; }
        public virtual ICollection<Bn1bon10> Bn1bon10 { get; set; }
    }
}
