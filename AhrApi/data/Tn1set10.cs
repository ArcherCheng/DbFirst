using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tn1set10
    {
        public Tn1set10()
        {
            Tn1cor10 = new HashSet<Tn1cor10>();
            Tn1new20 = new HashSet<Tn1new20>();
            Tn1new30 = new HashSet<Tn1new30>();
            Tn1new50 = new HashSet<Tn1new50>();
            Tn1trn10 = new HashSet<Tn1trn10>();
        }

        public string TnNo { get; set; }
        public string TnNm { get; set; }
        public string TnType { get; set; }
        public string TnCode { get; set; }
        public decimal? TnWeight { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Tn1set20 TnTypeNavigation { get; set; }
        public virtual Tn1new10 Tn1new10 { get; set; }
        public virtual ICollection<Tn1cor10> Tn1cor10 { get; set; }
        public virtual ICollection<Tn1new20> Tn1new20 { get; set; }
        public virtual ICollection<Tn1new30> Tn1new30 { get; set; }
        public virtual ICollection<Tn1new50> Tn1new50 { get; set; }
        public virtual ICollection<Tn1trn10> Tn1trn10 { get; set; }
    }
}
