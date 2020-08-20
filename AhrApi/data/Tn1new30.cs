﻿using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tn1new30
    {
        public string PosNo { get; set; }
        public string TnNo { get; set; }
        public decimal TnHr { get; set; }
        public decimal TnCost { get; set; }
        public decimal? TnWeight { get; set; }
        public string TnMethod { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1pos10 PosNoNavigation { get; set; }
        public virtual Tn1set10 TnNoNavigation { get; set; }
    }
}
