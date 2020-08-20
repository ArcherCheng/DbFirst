using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa4report
    {
        public string PgmNo { get; set; }
        public string PgmNm { get; set; }
        public string ReportType { get; set; }
        public string ReportList { get; set; }
        public string ExeMwd { get; set; }
        public decimal? ExeNn { get; set; }
        public string ExeTime { get; set; }
        public DateTime? ExeLastDate { get; set; }
        public DateTime? ExeNextDate { get; set; }
        public string PageType { get; set; }
        public string ColWt { get; set; }
        public string ParmValue { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
