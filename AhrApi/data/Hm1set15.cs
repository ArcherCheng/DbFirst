using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1set15
    {
        public Hm1set15()
        {
            Hm1emp15 = new HashSet<Hm1emp15>();
        }

        public string OutId { get; set; }
        public string OutDesc { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Hm1emp15> Hm1emp15 { get; set; }
    }
}
