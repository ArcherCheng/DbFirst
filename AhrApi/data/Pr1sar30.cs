using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Pr1sar30
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string DeptNo { get; set; }
        public string PosNo { get; set; }
        public string NewSdate { get; set; }
        public string NewAdjId { get; set; }
        public string NewDeptNo { get; set; }
        public string NewPosNo { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
