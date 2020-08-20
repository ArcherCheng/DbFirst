using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1emp11
    {
        public string EmpNo { get; set; }
        public string SchNm { get; set; }
        public string Major { get; set; }
        public string Cmon1 { get; set; }
        public string Cmon2 { get; set; }
        public string Graduate { get; set; }
        public string Sch12 { get; set; }
        public string SchNo { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
