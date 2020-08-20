using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1set60
    {
        public string SarLevel { get; set; }
        public string DutyNo { get; set; }
        public decimal DutyAmt { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
