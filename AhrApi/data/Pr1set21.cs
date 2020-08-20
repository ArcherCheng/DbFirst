using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Pr1set21
    {
        public string BnkNo { get; set; }
        public decimal BnkSeq { get; set; }
        public string Bnk12 { get; set; }
        public string BnkCol { get; set; }
        public decimal? BnkLen { get; set; }
        public string BnkNote { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Pr1set20 BnkNoNavigation { get; set; }
    }
}
