using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1emp13
    {
        public string EmpNo { get; set; }
        public string RelNm { get; set; }
        public string RelId { get; set; }
        public string CalYn { get; set; }
        public string Birthday { get; set; }
        public string CompNm { get; set; }
        public string DeptNm { get; set; }
        public string PosNm { get; set; }
        public decimal? Salary { get; set; }
        public string Tel { get; set; }
        public string GrpYn { get; set; }
        public string Cdate1 { get; set; }
        public string Cdate2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
