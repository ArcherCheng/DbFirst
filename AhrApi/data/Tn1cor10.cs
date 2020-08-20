using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tn1cor10
    {
        public Tn1cor10()
        {
            Tn1cor20 = new HashSet<Tn1cor20>();
        }

        public string CorNo { get; set; }
        public string TnNo { get; set; }
        public string Sdate1 { get; set; }
        public string Stime1 { get; set; }
        public string Sdate2 { get; set; }
        public string Stime2 { get; set; }
        public decimal TnHr { get; set; }
        public decimal TnCost { get; set; }
        public decimal? TnWeight { get; set; }
        public string TnMethod { get; set; }
        public string Teacher { get; set; }
        public string TnPlcae { get; set; }
        public decimal? Pns1 { get; set; }
        public decimal? Pns2 { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Tn1set10 TnNoNavigation { get; set; }
        public virtual ICollection<Tn1cor20> Tn1cor20 { get; set; }
    }
}
