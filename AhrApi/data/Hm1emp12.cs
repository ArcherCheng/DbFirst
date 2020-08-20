using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1emp12
    {
        public string EmpNo { get; set; }
        public string ComNm { get; set; }
        public string DeptNm { get; set; }
        public string PosNm { get; set; }
        public string Cmon1 { get; set; }
        public string Cmon2 { get; set; }
        public decimal? Years { get; set; }
        public decimal? Months { get; set; }
        public decimal? WorkYears { get; set; }
        public decimal? WorkMonths { get; set; }
        public decimal? Salary { get; set; }
        public string OutNote { get; set; }
        public string OutDoc { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
