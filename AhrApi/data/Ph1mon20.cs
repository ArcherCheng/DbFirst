using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1mon20
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public string RelId { get; set; }
        public string RelNm { get; set; }
        public string Sdate { get; set; }
        public decimal HeaAmt { get; set; }
        public string AdjYn { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
