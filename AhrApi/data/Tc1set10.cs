using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1set10
    {
        public Tc1set10()
        {
            Tc1grp40 = new HashSet<Tc1grp40>();
            Tc1set40 = new HashSet<Tc1set40>();
        }

        public string DutyNo { get; set; }
        public string DutyNm { get; set; }
        public string DutyType { get; set; }
        public string DutyOta { get; set; }
        public string DutyOtb { get; set; }
        public string DutyOtNo1 { get; set; }
        public string DutyOn { get; set; }
        public decimal? DutyMin { get; set; }
        public string DutyLatea { get; set; }
        public string DutyLateb { get; set; }
        public string DutyResta { get; set; }
        public string DutyRestb { get; set; }
        public string DutyOff { get; set; }
        public decimal DutyHr { get; set; }
        public string DutyOtc { get; set; }
        public string DutyOtd { get; set; }
        public string DutyOtNo2 { get; set; }
        public string OtId { get; set; }
        public string OtId2 { get; set; }
        public decimal? CardTms { get; set; }
        public decimal DutyAmt { get; set; }
        public decimal DutyAmt2 { get; set; }
        public string CalType { get; set; }
        public decimal CalHr { get; set; }
        public string CalTime { get; set; }
        public string NightYn { get; set; }
        public string NightType { get; set; }
        public string Stime11 { get; set; }
        public string Stime12 { get; set; }
        public decimal NightHr1 { get; set; }
        public decimal HrAmt11 { get; set; }
        public decimal HrAmt12 { get; set; }
        public string Stime21 { get; set; }
        public string Stime22 { get; set; }
        public decimal NightHr2 { get; set; }
        public decimal HrAmt21 { get; set; }
        public decimal HrAmt22 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Tc1grp40> Tc1grp40 { get; set; }
        public virtual ICollection<Tc1set40> Tc1set40 { get; set; }
    }
}
