using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1emp10
    {
        public Hm1emp10()
        {
            Bn1bon10 = new HashSet<Bn1bon10>();
            Hm1emp11 = new HashSet<Hm1emp11>();
            Hm1emp12 = new HashSet<Hm1emp12>();
            Hm1emp13 = new HashSet<Hm1emp13>();
            Hm1emp14 = new HashSet<Hm1emp14>();
            Hm1emp15 = new HashSet<Hm1emp15>();
            Hm1emp16 = new HashSet<Hm1emp16>();
            Lv1leav10 = new HashSet<Lv1leav10>();
            Lv1leav20 = new HashSet<Lv1leav20>();
            Lv1mon10 = new HashSet<Lv1mon10>();
            Lv1year10 = new HashSet<Lv1year10>();
            Ot1ovt10 = new HashSet<Ot1ovt10>();
            Ot1ovt20 = new HashSet<Ot1ovt20>();
            Ph1adj50 = new HashSet<Ph1adj50>();
            Ph1dat10 = new HashSet<Ph1dat10>();
            Ph1dat20 = new HashSet<Ph1dat20>();
            Ph1mon10 = new HashSet<Ph1mon10>();
            Pr1oth10 = new HashSet<Pr1oth10>();
            Pr1oth20 = new HashSet<Pr1oth20>();
            Pr1pay10 = new HashSet<Pr1pay10>();
            Pr1pay20 = new HashSet<Pr1pay20>();
            Pr1pay30 = new HashSet<Pr1pay30>();
            Pr1pay40 = new HashSet<Pr1pay40>();
            Pr1sar10 = new HashSet<Pr1sar10>();
            Py1oth10 = new HashSet<Py1oth10>();
            Py1oth20 = new HashSet<Py1oth20>();
            Py1oth30 = new HashSet<Py1oth30>();
            Py1tax10 = new HashSet<Py1tax10>();
            Py1tax20 = new HashSet<Py1tax20>();
            Py1tax30 = new HashSet<Py1tax30>();
            Rw1rcd10 = new HashSet<Rw1rcd10>();
            Sc1mon10 = new HashSet<Sc1mon10>();
            Sc1yer10 = new HashSet<Sc1yer10>();
            Tc1dat10 = new HashSet<Tc1dat10>();
            Tc1dat20 = new HashSet<Tc1dat20>();
            Tc1dat30 = new HashSet<Tc1dat30>();
            Tc1dat40 = new HashSet<Tc1dat40>();
            Tc1eat10 = new HashSet<Tc1eat10>();
            Tc1eat30 = new HashSet<Tc1eat30>();
            Tc1grp30 = new HashSet<Tc1grp30>();
            Tc1grp40 = new HashSet<Tc1grp40>();
            Tc1grp50 = new HashSet<Tc1grp50>();
            Tc1tcd10 = new HashSet<Tc1tcd10>();
            Tn1cor20 = new HashSet<Tn1cor20>();
            Tn1new50 = new HashSet<Tn1new50>();
            Tn1trn10 = new HashSet<Tn1trn10>();
            Wk1mon10 = new HashSet<Wk1mon10>();
            Wk1mon20 = new HashSet<Wk1mon20>();
            Wk1wok10 = new HashSet<Wk1wok10>();
        }

        public string EmpNo { get; set; }
        public string EmpNm { get; set; }
        public decimal? AutWt { get; set; }
        public string EmpId { get; set; }
        public string Sex { get; set; }
        public string Nation12 { get; set; }
        public string Birthday { get; set; }
        public string InDate { get; set; }
        public string OutDate { get; set; }
        public string InDate1 { get; set; }
        public string OutDate1 { get; set; }
        public string LastDate { get; set; }
        public string Dtype { get; set; }
        public string CardYn { get; set; }
        public string CardNo { get; set; }
        public string CardChkYn { get; set; }
        public string EatType { get; set; }
        public string DutyCd { get; set; }
        public string OverCd { get; set; }
        public string AutoOtYn { get; set; }
        public string GrpNo { get; set; }
        public string DutyNo1 { get; set; }
        public string DutyNo2 { get; set; }
        public string DutyNo3 { get; set; }
        public string DutyNo4 { get; set; }
        public string DutyNo5 { get; set; }
        public string DutyNo6 { get; set; }
        public string DutyNo7 { get; set; }
        public string Duty12 { get; set; }
        public string AutoAmtCd { get; set; }
        public decimal? TaxPns { get; set; }
        public string SarYn { get; set; }
        public string HalfYn { get; set; }
        public decimal HalfAmt { get; set; }
        public decimal? SarDay { get; set; }
        public string BnkNo { get; set; }
        public string BnkAccp { get; set; }
        public string BnkNo2 { get; set; }
        public string BnkAccp2 { get; set; }
        public string BnkNo3 { get; set; }
        public string BnkAccp3 { get; set; }
        public string BnkAccp3nm { get; set; }
        public decimal? Years { get; set; }
        public decimal? Months { get; set; }
        public decimal? Days { get; set; }
        public string CalYn1 { get; set; }
        public string CalYn2 { get; set; }
        public string CalYn3 { get; set; }
        public string PensionYn { get; set; }
        public string PensionDate { get; set; }
        public string TestDate { get; set; }
        public string BonusDate { get; set; }
        public string AnuType { get; set; }
        public string AnuDate { get; set; }
        public decimal? AnuDhr { get; set; }
        public string AnuNextYn { get; set; }
        public decimal? AnuNextDhr { get; set; }
        public string AnuYn { get; set; }
        public decimal? AnuYnDhr { get; set; }
        public string OtlvNextYn { get; set; }
        public decimal? OtlvNextDhr { get; set; }
        public string OtlvYn { get; set; }
        public decimal? OtlvYnDhr { get; set; }
        public string BirAddr { get; set; }
        public string Addr1No { get; set; }
        public string Addr1 { get; set; }
        public string Tel1 { get; set; }
        public string Addr2No { get; set; }
        public string Addr2 { get; set; }
        public string Tel2 { get; set; }
        public string SchNo { get; set; }
        public decimal? SchYear { get; set; }
        public string Sch12 { get; set; }
        public string School { get; set; }
        public string SchObj { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }
        public string EngNm { get; set; }
        public string Passport { get; set; }
        public string PassName { get; set; }
        public string Soldier { get; set; }
        public string Blood { get; set; }
        public string Marry { get; set; }
        public string Spouse { get; set; }
        public string ExtTel { get; set; }
        public string BossNo { get; set; }
        public string AgentNo1 { get; set; }
        public string AgentNo2 { get; set; }
        public string Introducer { get; set; }
        public string RelNm { get; set; }
        public string RelSpec { get; set; }
        public string RelTel1 { get; set; }
        public string RelTel2 { get; set; }
        public string CarId { get; set; }
        public string CarType { get; set; }
        public string MobileTel { get; set; }
        public string Nature { get; set; }
        public string Technic { get; set; }
        public string Interest { get; set; }
        public string Languages { get; set; }
        public string Parts { get; set; }
        public string Religion { get; set; }
        public string Nation { get; set; }
        public string AdNo { get; set; }
        public string Email { get; set; }
        public string Passwords { get; set; }
        public string ErrId { get; set; }
        public string TaxId { get; set; }
        public string NationCode { get; set; }
        public string CripYn { get; set; }
        public string CripType { get; set; }
        public string CripLevel { get; set; }
        public string CripNo { get; set; }
        public string ForeDate1 { get; set; }
        public string ForeDate2 { get; set; }
        public string ForeNo { get; set; }
        public string ForeNote { get; set; }
        public string PicFile { get; set; }
        public string Note1 { get; set; }
        public string PsNote1 { get; set; }
        public string PsNote2 { get; set; }
        public string PsNote3 { get; set; }
        public string PsNote4 { get; set; }
        public string PsNote5 { get; set; }
        public string PsNote6 { get; set; }
        public string PsNote7 { get; set; }
        public string PsNote8 { get; set; }
        public string PsNote9 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public string ComNo { get; set; }
        public string DeptNo { get; set; }
        public string PosNo { get; set; }

        public virtual Hm1emp20 Hm1emp20 { get; set; }
        public virtual ICollection<Bn1bon10> Bn1bon10 { get; set; }
        public virtual ICollection<Hm1emp11> Hm1emp11 { get; set; }
        public virtual ICollection<Hm1emp12> Hm1emp12 { get; set; }
        public virtual ICollection<Hm1emp13> Hm1emp13 { get; set; }
        public virtual ICollection<Hm1emp14> Hm1emp14 { get; set; }
        public virtual ICollection<Hm1emp15> Hm1emp15 { get; set; }
        public virtual ICollection<Hm1emp16> Hm1emp16 { get; set; }
        public virtual ICollection<Lv1leav10> Lv1leav10 { get; set; }
        public virtual ICollection<Lv1leav20> Lv1leav20 { get; set; }
        public virtual ICollection<Lv1mon10> Lv1mon10 { get; set; }
        public virtual ICollection<Lv1year10> Lv1year10 { get; set; }
        public virtual ICollection<Ot1ovt10> Ot1ovt10 { get; set; }
        public virtual ICollection<Ot1ovt20> Ot1ovt20 { get; set; }
        public virtual ICollection<Ph1adj50> Ph1adj50 { get; set; }
        public virtual ICollection<Ph1dat10> Ph1dat10 { get; set; }
        public virtual ICollection<Ph1dat20> Ph1dat20 { get; set; }
        public virtual ICollection<Ph1mon10> Ph1mon10 { get; set; }
        public virtual ICollection<Pr1oth10> Pr1oth10 { get; set; }
        public virtual ICollection<Pr1oth20> Pr1oth20 { get; set; }
        public virtual ICollection<Pr1pay10> Pr1pay10 { get; set; }
        public virtual ICollection<Pr1pay20> Pr1pay20 { get; set; }
        public virtual ICollection<Pr1pay30> Pr1pay30 { get; set; }
        public virtual ICollection<Pr1pay40> Pr1pay40 { get; set; }
        public virtual ICollection<Pr1sar10> Pr1sar10 { get; set; }
        public virtual ICollection<Py1oth10> Py1oth10 { get; set; }
        public virtual ICollection<Py1oth20> Py1oth20 { get; set; }
        public virtual ICollection<Py1oth30> Py1oth30 { get; set; }
        public virtual ICollection<Py1tax10> Py1tax10 { get; set; }
        public virtual ICollection<Py1tax20> Py1tax20 { get; set; }
        public virtual ICollection<Py1tax30> Py1tax30 { get; set; }
        public virtual ICollection<Rw1rcd10> Rw1rcd10 { get; set; }
        public virtual ICollection<Sc1mon10> Sc1mon10 { get; set; }
        public virtual ICollection<Sc1yer10> Sc1yer10 { get; set; }
        public virtual ICollection<Tc1dat10> Tc1dat10 { get; set; }
        public virtual ICollection<Tc1dat20> Tc1dat20 { get; set; }
        public virtual ICollection<Tc1dat30> Tc1dat30 { get; set; }
        public virtual ICollection<Tc1dat40> Tc1dat40 { get; set; }
        public virtual ICollection<Tc1eat10> Tc1eat10 { get; set; }
        public virtual ICollection<Tc1eat30> Tc1eat30 { get; set; }
        public virtual ICollection<Tc1grp30> Tc1grp30 { get; set; }
        public virtual ICollection<Tc1grp40> Tc1grp40 { get; set; }
        public virtual ICollection<Tc1grp50> Tc1grp50 { get; set; }
        public virtual ICollection<Tc1tcd10> Tc1tcd10 { get; set; }
        public virtual ICollection<Tn1cor20> Tn1cor20 { get; set; }
        public virtual ICollection<Tn1new50> Tn1new50 { get; set; }
        public virtual ICollection<Tn1trn10> Tn1trn10 { get; set; }
        public virtual ICollection<Wk1mon10> Wk1mon10 { get; set; }
        public virtual ICollection<Wk1mon20> Wk1mon20 { get; set; }
        public virtual ICollection<Wk1wok10> Wk1wok10 { get; set; }
    }
}
