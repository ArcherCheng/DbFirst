﻿using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa1batch
    {
        public string BatchCd { get; set; }
        public int? BatchOn { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
