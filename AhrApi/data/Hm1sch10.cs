using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1sch10
    {
        public string SchNo { get; set; }
        public string SchNm { get; set; }
        public decimal SchLev { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
