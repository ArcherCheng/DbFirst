using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1dat30
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string Stime1 { get; set; }
        public string Stime2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
