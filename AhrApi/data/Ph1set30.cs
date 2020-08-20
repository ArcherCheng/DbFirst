using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1set30
    {
        public Ph1set30()
        {
            Ph1dat20 = new HashSet<Ph1dat20>();
        }

        public string InsReason { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Ph1dat20> Ph1dat20 { get; set; }
    }
}
