using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Lv1set10
    {
        public Lv1set10()
        {
            Lv1leav10 = new HashSet<Lv1leav10>();
            Lv1leav20 = new HashSet<Lv1leav20>();
        }

        public string LvNo { get; set; }
        public string LvNm { get; set; }
        public string LvUnit { get; set; }
        public string LvType { get; set; }
        public string LvNo1 { get; set; }
        public string LvNo2 { get; set; }
        public string SubHrYn { get; set; }
        public string SubOtYn { get; set; }
        public string SubOtType { get; set; }
        public decimal? FreeHr { get; set; }
        public string MonLvYn { get; set; }
        public string MonLvEmp { get; set; }
        public string MonYn1 { get; set; }
        public decimal? MonRate1 { get; set; }
        public decimal? MonDay { get; set; }
        public decimal? MonRate { get; set; }
        public decimal? MonHr1 { get; set; }
        public decimal? MonHr2 { get; set; }
        public decimal? MonHr3 { get; set; }
        public decimal? MonHr4 { get; set; }
        public decimal? MonTm1 { get; set; }
        public string MonBase { get; set; }
        public string MonBase2 { get; set; }
        public string YearLvYn { get; set; }
        public decimal? YearFreeHr { get; set; }
        public decimal? YearRate { get; set; }
        public decimal? YearHr { get; set; }
        public decimal? YearTm { get; set; }
        public string YearBase { get; set; }
        public string YearBase2 { get; set; }
        public string YearCanYn { get; set; }
        public string YearCrtlYn { get; set; }
        public string MealYn { get; set; }
        public string MealYn2 { get; set; }
        public decimal? MealRate { get; set; }
        public decimal? MealHr { get; set; }
        public decimal? MealAmt { get; set; }
        public string MealBase { get; set; }
        public string DutyYn { get; set; }
        public decimal? DutyRate { get; set; }
        public decimal? DutyHr { get; set; }
        public decimal? DutyMod { get; set; }
        public decimal? DutyAmt { get; set; }
        public string DutyBase { get; set; }
        public string DutyNight { get; set; }
        public string OthYn { get; set; }
        public decimal? OthRate { get; set; }
        public decimal? OthHr { get; set; }
        public decimal? OthAmt { get; set; }
        public string OthBase { get; set; }
        public string CstFunc { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public string LvNmEng { get; set; }

        public virtual ICollection<Lv1leav10> Lv1leav10 { get; set; }
        public virtual ICollection<Lv1leav20> Lv1leav20 { get; set; }
    }
}
