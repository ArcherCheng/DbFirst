using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tn1new20
    {
        public string DeptNo { get; set; }
        public string TnNo { get; set; }
        public decimal TnHr { get; set; }
        public decimal TnCost { get; set; }
        public decimal? TnWeight { get; set; }
        public string TnMethod { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1dept10 DeptNoNavigation { get; set; }
        public virtual Tn1set10 TnNoNavigation { get; set; }
    }
}
