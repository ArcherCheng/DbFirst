using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1emp14
    {
        public string EmpNo { get; set; }
        public string Certificate { get; set; }
        public string Cdate1 { get; set; }
        public string Cdate2 { get; set; }
        public string Publishname { get; set; }
        public string Publishman { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
