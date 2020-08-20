using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa4pgmNo
    {
        public Aa4pgmNo()
        {
            Aa4userLove = new HashSet<Aa4userLove>();
            Aa4userPgm = new HashSet<Aa4userPgm>();
        }

        public string PgmNo { get; set; }
        public string PgmNm { get; set; }
        public string SysNo { get; set; }
        public decimal? PgmSeq { get; set; }
        public string PgmType { get; set; }
        public byte? PgmVersion { get; set; }
        public string PgmNext { get; set; }
        public string PgmPrior { get; set; }
        public string PgmWindow { get; set; }
        public string PgmTableId { get; set; }
        public string PgmRetrieve { get; set; }
        public string CanRetrieve { get; set; }
        public string CanInsert { get; set; }
        public string CanModify { get; set; }
        public string CanDelete { get; set; }
        public string CanSave { get; set; }
        public string CanSaveas { get; set; }
        public string CanPrint { get; set; }
        public string FootCd { get; set; }
        public string FootText1 { get; set; }
        public string FootText2 { get; set; }
        public string FootText3 { get; set; }
        public string FootText4 { get; set; }
        public string FootText5 { get; set; }
        public string IsoText { get; set; }
        public string Dataobject { get; set; }
        public string ExeAuto { get; set; }
        public string ExePrompt { get; set; }
        public string ExeYmwdh { get; set; }
        public decimal? ExeNn { get; set; }
        public string ExeTime { get; set; }
        public DateTime? ExeDate { get; set; }
        public string ExeSuccess { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Aa4userLove> Aa4userLove { get; set; }
        public virtual ICollection<Aa4userPgm> Aa4userPgm { get; set; }
    }
}
