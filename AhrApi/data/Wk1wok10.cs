using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Wk1wok10
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string Smon { get; set; }
        public string WkItem { get; set; }
        public decimal? WkQty { get; set; }
        public string Note1 { get; set; }
        public decimal WkAmt { get; set; }
        public string AdjYn { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Wk1set10 WkItemNavigation { get; set; }
    }
}
