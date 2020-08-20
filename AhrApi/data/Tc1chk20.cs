using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1chk20
    {
        public string ErrType { get; set; }
        public string EmpNo { get; set; }
        public string Sdate1 { get; set; }
        public string Stime1 { get; set; }
        public string Sdate2 { get; set; }
        public string Stime2 { get; set; }
        public decimal? Hours { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
