using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1set20
    {
        public Ph1set20()
        {
            Ph1dat10 = new HashSet<Ph1dat10>();
            Ph1dat20 = new HashSet<Ph1dat20>();
        }

        public string InsType { get; set; }
        public string Note1 { get; set; }
        public decimal InsRate { get; set; }
        public decimal InsRate2 { get; set; }
        public decimal MaxAmt { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public decimal? OldMaxAmt { get; set; }

        public virtual ICollection<Ph1dat10> Ph1dat10 { get; set; }
        public virtual ICollection<Ph1dat20> Ph1dat20 { get; set; }
    }
}
