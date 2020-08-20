using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1set10
    {
        public Ph1set10()
        {
            Ph1dat10 = new HashSet<Ph1dat10>();
        }

        public decimal InsAmt { get; set; }
        public string Smon { get; set; }
        public decimal? PnsIn { get; set; }
        public decimal? PnsOut { get; set; }
        public decimal? PnsNow { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public decimal? GovAdd { get; set; }

        public virtual ICollection<Ph1dat10> Ph1dat10 { get; set; }
    }
}
