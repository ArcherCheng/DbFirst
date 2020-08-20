using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Rw1rcd10
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string Smon { get; set; }
        public string DocNo { get; set; }
        public string RwCd { get; set; }
        public decimal? RwSum { get; set; }
        public decimal? RwAmt { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Rw1set10 RwCdNavigation { get; set; }
    }
}
