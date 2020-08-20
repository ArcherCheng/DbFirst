using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Bn1bon50
    {
        public string EmpNo { get; set; }
        public string Smon { get; set; }
        public decimal NetAmt { get; set; }
        public string Note1 { get; set; }
        public string BnkNo { get; set; }
        public string BnkAccp { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
