using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1dat80
    {
        public string EmpNo { get; set; }
        public string DeptNo { get; set; }
        public string Sdate { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public int? IdOver { get; set; }
    }
}
