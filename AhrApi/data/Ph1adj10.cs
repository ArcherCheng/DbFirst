using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1adj10
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public decimal InsAmt { get; set; }
        public decimal HeaAmt { get; set; }
        public decimal PenAmt { get; set; }
        public string NewSdate { get; set; }
        public decimal NewAmt1 { get; set; }
        public string ChkYn { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
