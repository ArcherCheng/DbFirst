using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1grp10
    {
        public Tc1grp10()
        {
            Tc1grp20 = new HashSet<Tc1grp20>();
        }

        public string GrpNo { get; set; }
        public string GrpNm { get; set; }
        public string Sdate { get; set; }
        public string Duty1 { get; set; }
        public string Duty2 { get; set; }
        public string Duty3 { get; set; }
        public string Duty4 { get; set; }
        public string Duty5 { get; set; }
        public string Duty6 { get; set; }
        public string Duty7 { get; set; }
        public string Duty8 { get; set; }
        public string Duty9 { get; set; }
        public string Duty10 { get; set; }
        public string Duty11 { get; set; }
        public string Duty12 { get; set; }
        public string Duty13 { get; set; }
        public string Duty14 { get; set; }
        public string Duty15 { get; set; }
        public decimal? Day1 { get; set; }
        public decimal? Day2 { get; set; }
        public decimal? Day3 { get; set; }
        public decimal? Day4 { get; set; }
        public decimal? Day5 { get; set; }
        public decimal? Day6 { get; set; }
        public decimal? Day7 { get; set; }
        public decimal? Day8 { get; set; }
        public decimal? Day9 { get; set; }
        public decimal? Day10 { get; set; }
        public decimal? Day11 { get; set; }
        public decimal? Day12 { get; set; }
        public decimal? Day13 { get; set; }
        public decimal? Day14 { get; set; }
        public decimal? Day15 { get; set; }
        public string Dutyx1 { get; set; }
        public string Dutyx2 { get; set; }
        public string Dutyx3 { get; set; }
        public string Dutyx4 { get; set; }
        public string Dutyx5 { get; set; }
        public string Dutyx6 { get; set; }
        public string Dutyx7 { get; set; }
        public string Dutyx8 { get; set; }
        public string Dutyx9 { get; set; }
        public string Dutyx10 { get; set; }
        public string Dutyx11 { get; set; }
        public string Dutyx12 { get; set; }
        public string Dutyx13 { get; set; }
        public string Dutyx14 { get; set; }
        public string Dutyx15 { get; set; }
        public decimal? Dayx1 { get; set; }
        public decimal? Dayx2 { get; set; }
        public decimal? Dayx3 { get; set; }
        public decimal? Dayx4 { get; set; }
        public decimal? Dayx5 { get; set; }
        public decimal? Dayx6 { get; set; }
        public decimal? Dayx7 { get; set; }
        public decimal? Dayx8 { get; set; }
        public decimal? Dayx9 { get; set; }
        public decimal? Dayx10 { get; set; }
        public decimal? Dayx11 { get; set; }
        public decimal? Dayx12 { get; set; }
        public decimal? Dayx13 { get; set; }
        public decimal? Dayx14 { get; set; }
        public decimal? Dayx15 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Tc1grp20> Tc1grp20 { get; set; }
    }
}
