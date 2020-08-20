using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1dat20
    {
        public string EmpNo { get; set; }
        public string RelCd { get; set; }
        public string RelNm { get; set; }
        public string RelId { get; set; }
        public string Birthday { get; set; }
        public string Sdate { get; set; }
        public string InsType { get; set; }
        public string InsReason { get; set; }
        public string Forn { get; set; }
        public string RetDate { get; set; }
        public string RetReason { get; set; }
        public string CalYn { get; set; }
        public decimal? SelfAmt { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Ph1set30 InsReasonNavigation { get; set; }
        public virtual Ph1set20 InsTypeNavigation { get; set; }
        public virtual Ph1set40 RelCdNavigation { get; set; }
    }
}
