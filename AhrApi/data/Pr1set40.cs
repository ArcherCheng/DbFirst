using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Pr1set40
    {
        public Pr1set40()
        {
            Pr1sar10 = new HashSet<Pr1sar10>();
        }

        public string SarAttr { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public int? IdOver { get; set; }

        public virtual ICollection<Pr1sar10> Pr1sar10 { get; set; }
    }
}
