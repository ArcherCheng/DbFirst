using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1dat40
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string Stime { get; set; }
        public string OnoffId { get; set; }
        public decimal? Amt { get; set; }
        public string LvYn { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
