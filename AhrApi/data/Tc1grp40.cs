﻿using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1grp40
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string DutyNo { get; set; }
        public string Duty12 { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Tc1set10 DutyNoNavigation { get; set; }
        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
