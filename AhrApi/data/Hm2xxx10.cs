using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm2xxx10
    {
        public string KeyNo { get; set; }
        public string KeyNm { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
