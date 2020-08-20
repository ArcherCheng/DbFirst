using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ph1adj50
    {
        public string Syear { get; set; }
        public string EmpNo { get; set; }
        public string CalSdate { get; set; }
        public string PenSdate { get; set; }
        public string PenType { get; set; }
        public byte? Years { get; set; }
        public byte? Mons { get; set; }
        public byte? Olds { get; set; }
        public string Sex { get; set; }
        public decimal AvgWage { get; set; }
        public decimal PenMons { get; set; }
        public decimal PenAmt { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Ph1adj40 PenTypeNavigation { get; set; }
    }
}
