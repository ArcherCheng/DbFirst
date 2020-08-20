using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1emp16
    {
        public string EmpNo { get; set; }
        public string Sdate1 { get; set; }
        public string Sdate2 { get; set; }
        public string Note1 { get; set; }
        public decimal? SubYears { get; set; }
        public decimal? SubMons { get; set; }
        public decimal? SubDays { get; set; }
        public string SubYear1 { get; set; }
        public string SubYear2 { get; set; }
        public string SubYear3 { get; set; }
        public string BackSdate { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
