using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Bn1bon40
    {
        public string EmpNo { get; set; }
        public string BnNo { get; set; }
        public string Sdate { get; set; }
        public decimal BaseAmt { get; set; }
        public string Smon1 { get; set; }
        public decimal? BnDays1 { get; set; }
        public decimal BnAmt1 { get; set; }
        public decimal ScoreAmt1 { get; set; }
        public decimal RwAmt1 { get; set; }
        public decimal LvAmt1 { get; set; }
        public decimal DeptAmt1 { get; set; }
        public decimal LevelAmt1 { get; set; }
        public decimal PosAmt1 { get; set; }
        public decimal TotAmt1 { get; set; }
        public decimal BnTax1 { get; set; }
        public decimal NetAmt1 { get; set; }
        public string AdjYn1 { get; set; }
        public decimal? ScoreQty { get; set; }
        public decimal? RwQty { get; set; }
        public decimal? LvQty { get; set; }
        public decimal? DeptQty { get; set; }
        public decimal? LevelQty { get; set; }
        public decimal? PosQty { get; set; }
        public string Smon2 { get; set; }
        public decimal? BnDays2 { get; set; }
        public decimal BnAmt2 { get; set; }
        public decimal BnTax2 { get; set; }
        public decimal NetAmt2 { get; set; }
        public string AdjYn2 { get; set; }
        public int? Years { get; set; }
        public int? Mons { get; set; }
        public int? Days { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
