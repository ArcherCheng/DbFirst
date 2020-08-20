using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Rw1set10
    {
        public Rw1set10()
        {
            Rw1rcd10 = new HashSet<Rw1rcd10>();
        }

        public string RwCd { get; set; }
        public string RwNm { get; set; }
        public decimal? RwScore { get; set; }
        public decimal RwAmt { get; set; }
        public decimal? RwDay { get; set; }
        public decimal? RwRate { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Rw1rcd10> Rw1rcd10 { get; set; }
    }
}
