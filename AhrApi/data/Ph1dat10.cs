using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1dat10
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public decimal InsAmt { get; set; }
        public string InsType { get; set; }
        public string JobYn { get; set; }
        public decimal HeaAmt { get; set; }
        public string InsReason { get; set; }
        public decimal PenAmt { get; set; }
        public decimal? Rate1 { get; set; }
        public decimal? Rate2 { get; set; }
        public string Note1 { get; set; }
        public string RetDate { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public string RetReason { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Ph1set10 InsAmtNavigation { get; set; }
        public virtual Ph1set20 InsTypeNavigation { get; set; }
    }
}
