﻿using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1dat20
    {
        public string EmpNo { get; set; }
        public string Sdate1 { get; set; }
        public string Sdate2 { get; set; }
        public string CardNo { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
    }
}
