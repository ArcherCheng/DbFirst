using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa4sysNo
    {
        public string SysNo { get; set; }
        public string SysNm { get; set; }
        public decimal SysSeq { get; set; }
        public string SysWindow { get; set; }
        public string NoteId1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
