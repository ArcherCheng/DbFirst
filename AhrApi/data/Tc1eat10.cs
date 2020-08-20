using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1eat10
    {
        public string CardStr { get; set; }
        public string CardNo { get; set; }
        public string EmpNo { get; set; }
        public string MachNo { get; set; }
        public string Sdate { get; set; }
        public string Stime { get; set; }
        public string OnoffId { get; set; }
        public string TcfType { get; set; }
        public string EatType { get; set; }
        public decimal EatAmt1 { get; set; }
        public decimal EatAmt2 { get; set; }
        public string CancelYn { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Tc1set20 TcfTypeNavigation { get; set; }
    }
}
