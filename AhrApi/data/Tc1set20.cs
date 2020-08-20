using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1set20
    {
        public Tc1set20()
        {
            Tc1eat10 = new HashSet<Tc1eat10>();
            Tc1eat20 = new HashSet<Tc1eat20>();
            Tc1tcd10 = new HashSet<Tc1tcd10>();
            Tc1tcd20 = new HashSet<Tc1tcd20>();
        }

        public string TcfType { get; set; }
        public string TcfNote { get; set; }
        public string TcfFile { get; set; }
        public decimal? TcfCard1 { get; set; }
        public decimal? TcfCard2 { get; set; }
        public decimal? TcfLt1 { get; set; }
        public decimal? TcfLt2 { get; set; }
        public decimal? TcfMach1 { get; set; }
        public decimal? TcfMach2 { get; set; }
        public decimal? TcfYy1 { get; set; }
        public decimal? TcfYy2 { get; set; }
        public decimal? TcfMm1 { get; set; }
        public decimal? TcfMm2 { get; set; }
        public decimal? TcfDd1 { get; set; }
        public decimal? TcfDd2 { get; set; }
        public decimal? TcfHh1 { get; set; }
        public decimal? TcfHh2 { get; set; }
        public decimal? TcfMs1 { get; set; }
        public decimal? TcfMs2 { get; set; }
        public string TcfLtMode { get; set; }
        public string TcfOn { get; set; }
        public string TcfOff { get; set; }
        public string TcfOtOn { get; set; }
        public string TcfOtOff { get; set; }
        public decimal? TcaA1 { get; set; }
        public decimal? TcaN1 { get; set; }
        public string TcaT1 { get; set; }
        public decimal? TcaA2 { get; set; }
        public decimal? TcaN2 { get; set; }
        public string TcaT2 { get; set; }
        public decimal? TcaA3 { get; set; }
        public decimal? TcaN3 { get; set; }
        public string TcaT3 { get; set; }
        public decimal? TcaA4 { get; set; }
        public decimal? TcaN4 { get; set; }
        public string TcaT4 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Tc1eat10> Tc1eat10 { get; set; }
        public virtual ICollection<Tc1eat20> Tc1eat20 { get; set; }
        public virtual ICollection<Tc1tcd10> Tc1tcd10 { get; set; }
        public virtual ICollection<Tc1tcd20> Tc1tcd20 { get; set; }
    }
}
