using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tn1cor20
    {
        public string CorNo { get; set; }
        public string EmpNo { get; set; }
        public string Email { get; set; }
        public string MobileTel { get; set; }
        public string Chk1 { get; set; }
        public string Chk2 { get; set; }
        public decimal? Scores { get; set; }
        public string TnYn { get; set; }
        public string Note1 { get; set; }
        public string MailYn { get; set; }
        public string MobileYn { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Tn1cor10 CorNoNavigation { get; set; }
        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
