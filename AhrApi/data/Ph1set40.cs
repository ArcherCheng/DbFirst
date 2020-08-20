using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1set40
    {
        public Ph1set40()
        {
            Ph1dat20 = new HashSet<Ph1dat20>();
        }

        public string RelCd { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public int? IdOver { get; set; }

        public virtual ICollection<Ph1dat20> Ph1dat20 { get; set; }
    }
}
