using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1eat30
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public decimal EatAmt1 { get; set; }
        public decimal EatAmt2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
