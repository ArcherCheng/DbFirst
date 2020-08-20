using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa4userPgm
    {
        public string UserNo { get; set; }
        public string PgmNo { get; set; }
        public string CanRetrieve { get; set; }
        public string CanInsert { get; set; }
        public string CanModify { get; set; }
        public string CanDelete { get; set; }
        public string CanSave { get; set; }
        public string CanSaveas { get; set; }
        public string CanPrint { get; set; }
        public string ColWt { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Aa4pgmNo PgmNoNavigation { get; set; }
        public virtual Aa4userNo UserNoNavigation { get; set; }
    }
}
