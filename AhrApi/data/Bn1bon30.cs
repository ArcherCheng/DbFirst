using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Bn1bon30
    {
        public string Smon { get; set; }
        public string Sdate { get; set; }
        public string EmpNo { get; set; }
        public string DeptNo { get; set; }
        public string EmpId { get; set; }
        public string EmpNm { get; set; }
        public string Addr1 { get; set; }
        public string HeaType { get; set; }
        public decimal? BnAmt { get; set; }
        public decimal? HeaAmt2 { get; set; }
        public decimal? NetAmt { get; set; }
        public string Trust { get; set; }
        public string StockId { get; set; }
        public decimal? HeaAmt1 { get; set; }
        public string StockDate { get; set; }
        public decimal? StockTax1 { get; set; }
        public decimal? StockTax2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
