using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Pr1oth10
    {
        public string Smon { get; set; }
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string PrNo { get; set; }
        public decimal PrAmt { get; set; }
        public string Note1 { get; set; }
        public string PhType { get; set; }
        public string PhSmon { get; set; }
        public string RelId { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Pr1set10 PrNoNavigation { get; set; }
    }
}
