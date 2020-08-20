using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Pr1set10
    {
        public Pr1set10()
        {
            Bn1set10 = new HashSet<Bn1set10>();
            Pr1oth10 = new HashSet<Pr1oth10>();
            Pr1oth20 = new HashSet<Pr1oth20>();
        }

        public decimal? PrSeq1 { get; set; }
        public string PrNo { get; set; }
        public string PrNm { get; set; }
        public string PrYn1 { get; set; }
        public string PrYn2 { get; set; }
        public string PrYn3 { get; set; }
        public string PrType { get; set; }
        public string PrSpec { get; set; }
        public string PrExpl { get; set; }
        public string PrExpl2 { get; set; }
        public decimal? PrSeq2 { get; set; }
        public decimal? PrPos1 { get; set; }
        public decimal? PrPos2 { get; set; }
        public decimal? PrPos3 { get; set; }
        public string WageType { get; set; }
        public string PrCaculate { get; set; }
        public string PrHalfYn { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public string PrNmEng { get; set; }

        public virtual ICollection<Bn1set10> Bn1set10 { get; set; }
        public virtual ICollection<Pr1oth10> Pr1oth10 { get; set; }
        public virtual ICollection<Pr1oth20> Pr1oth20 { get; set; }
    }
}
