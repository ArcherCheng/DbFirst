using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tn1set20
    {
        public Tn1set20()
        {
            Tn1set10 = new HashSet<Tn1set10>();
        }

        public string TnType { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Tn1set10> Tn1set10 { get; set; }
    }
}
