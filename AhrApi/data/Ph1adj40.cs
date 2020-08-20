using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1adj40
    {
        public Ph1adj40()
        {
            Ph1adj50 = new HashSet<Ph1adj50>();
        }

        public string PenType { get; set; }
        public string PenNm { get; set; }
        public byte? Years { get; set; }
        public byte? Olds { get; set; }
        public string Sex { get; set; }
        public string PrBase { get; set; }
        public byte? PrMons { get; set; }
        public byte? MaxMons { get; set; }
        public byte? SplitYears { get; set; }
        public decimal? SplitMon1 { get; set; }
        public decimal? SplitMon2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Ph1adj50> Ph1adj50 { get; set; }
    }
}
