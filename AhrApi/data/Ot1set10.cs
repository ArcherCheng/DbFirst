using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ot1set10
    {
        public Ot1set10()
        {
            Ot1ovt10 = new HashSet<Ot1ovt10>();
            Ot1ovt20 = new HashSet<Ot1ovt20>();
        }

        public string OtId { get; set; }
        public string OtNm { get; set; }
        public string OtType { get; set; }
        public string OtUnit { get; set; }
        public string OtBase { get; set; }
        public string OtBase2 { get; set; }
        public string OtMode1 { get; set; }
        public string OtMode2 { get; set; }
        public decimal OtHr1 { get; set; }
        public decimal OtHr2 { get; set; }
        public string OtStime1 { get; set; }
        public string OtStime2 { get; set; }
        public decimal? OtRate1 { get; set; }
        public decimal? OtRate2 { get; set; }
        public decimal? OtRate3 { get; set; }
        public decimal OtAmt1 { get; set; }
        public decimal OtAmt2 { get; set; }
        public decimal OtAmt3 { get; set; }
        public string SbStime1 { get; set; }
        public string SbStime2 { get; set; }
        public string SbStime3 { get; set; }
        public string SbStime4 { get; set; }
        public string SbEtime1 { get; set; }
        public string SbEtime2 { get; set; }
        public string SbEtime3 { get; set; }
        public string SbEtime4 { get; set; }
        public decimal? SbMin1 { get; set; }
        public decimal? SbMin2 { get; set; }
        public decimal? SbMin3 { get; set; }
        public decimal? SbMin4 { get; set; }
        public string MealStime1 { get; set; }
        public string MealStime2 { get; set; }
        public string MealStime3 { get; set; }
        public string MealStime4 { get; set; }
        public string MealEtime1 { get; set; }
        public string MealEtime2 { get; set; }
        public string MealEtime3 { get; set; }
        public string MealEtime4 { get; set; }
        public decimal MealHr1 { get; set; }
        public decimal MealHr2 { get; set; }
        public decimal MealHr3 { get; set; }
        public decimal MealHr4 { get; set; }
        public decimal MealAmt1 { get; set; }
        public decimal MealAmt2 { get; set; }
        public decimal MealAmt3 { get; set; }
        public decimal MealAmt4 { get; set; }
        public decimal MealAmt1b { get; set; }
        public decimal MealAmt2b { get; set; }
        public decimal MealAmt3b { get; set; }
        public decimal MealAmt4b { get; set; }
        public string NightYn { get; set; }
        public string OtlvType { get; set; }
        public string OtlvMeal { get; set; }
        public string OtlvNightYn { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public decimal? FreeHr { get; set; }

        public virtual ICollection<Ot1ovt10> Ot1ovt10 { get; set; }
        public virtual ICollection<Ot1ovt20> Ot1ovt20 { get; set; }
    }
}
