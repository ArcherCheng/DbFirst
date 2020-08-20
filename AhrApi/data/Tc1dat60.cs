using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1dat60
    {
        public string DeptNo { get; set; }
        public string Sdate { get; set; }
        public decimal? DeptPns { get; set; }
        public decimal? OutPns { get; set; }
        public decimal? ActPns { get; set; }
        public decimal? DutyRate { get; set; }
        public decimal? LatePns { get; set; }
        public decimal? LvPns { get; set; }
        public decimal? OtPns { get; set; }
        public decimal? DutyHr { get; set; }
        public decimal? WorkHr { get; set; }
        public decimal? LvHr { get; set; }
        public decimal? OtHr { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
