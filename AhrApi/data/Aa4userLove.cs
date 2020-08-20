using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa4userLove
    {
        public string UserNo { get; set; }
        public string PgmNo { get; set; }
        public decimal? LoveSeq { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Aa4pgmNo PgmNoNavigation { get; set; }
        public virtual Aa4userNo UserNoNavigation { get; set; }
    }
}
