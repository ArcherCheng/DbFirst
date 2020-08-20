using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1set40
    {
        public string Dtype { get; set; }
        public string Sdate { get; set; }
        public string DutyNo { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Tc1set10 DutyNoNavigation { get; set; }
    }
}
