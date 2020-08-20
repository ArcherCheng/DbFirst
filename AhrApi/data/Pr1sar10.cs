using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Pr1sar10
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string AdjId { get; set; }
        public string ComNo { get; set; }
        public string DeptNo { get; set; }
        public string PosNo { get; set; }
        public string SarType { get; set; }
        public string SarAttr { get; set; }
        public string SarCost { get; set; }
        public string SarKind { get; set; }
        public string SarLevel { get; set; }
        public decimal? SarAll { get; set; }
        public decimal? DayHr { get; set; }
        public string AdjNote { get; set; }
        public decimal Pr01 { get; set; }
        public decimal Pr02 { get; set; }
        public decimal Pr03 { get; set; }
        public decimal Pr04 { get; set; }
        public decimal Pr05 { get; set; }
        public decimal Pr06 { get; set; }
        public decimal Pr07 { get; set; }
        public decimal Pr08 { get; set; }
        public decimal Pr09 { get; set; }
        public decimal Pr10 { get; set; }
        public decimal Pr11 { get; set; }
        public decimal Pr12 { get; set; }
        public decimal Pr13 { get; set; }
        public decimal Pr14 { get; set; }
        public decimal Pr15 { get; set; }
        public decimal Pr16 { get; set; }
        public decimal Pr17 { get; set; }
        public decimal Pr18 { get; set; }
        public decimal Pr19 { get; set; }
        public decimal Pr20 { get; set; }
        public decimal Pr21 { get; set; }
        public decimal Pr22 { get; set; }
        public decimal Pr23 { get; set; }
        public decimal Pr24 { get; set; }
        public decimal Pr25 { get; set; }
        public decimal Pr26 { get; set; }
        public decimal Pr27 { get; set; }
        public decimal Pr28 { get; set; }
        public decimal Pr29 { get; set; }
        public decimal Pr30 { get; set; }
        public decimal Pr31 { get; set; }
        public decimal Pr32 { get; set; }
        public decimal Pr33 { get; set; }
        public decimal Pr34 { get; set; }
        public decimal Pr35 { get; set; }
        public decimal Pr36 { get; set; }
        public decimal Pr37 { get; set; }
        public decimal Pr38 { get; set; }
        public decimal Pr39 { get; set; }
        public decimal Pr40 { get; set; }
        public string Md01 { get; set; }
        public string Md02 { get; set; }
        public string Md03 { get; set; }
        public string Md04 { get; set; }
        public string Md05 { get; set; }
        public string Md06 { get; set; }
        public string Md07 { get; set; }
        public string Md08 { get; set; }
        public string Md09 { get; set; }
        public string Md10 { get; set; }
        public string Md11 { get; set; }
        public string Md12 { get; set; }
        public string Md13 { get; set; }
        public string Md14 { get; set; }
        public string Md15 { get; set; }
        public string Md16 { get; set; }
        public string Md17 { get; set; }
        public string Md18 { get; set; }
        public string Md19 { get; set; }
        public string Md20 { get; set; }
        public string Md21 { get; set; }
        public string Md22 { get; set; }
        public string Md23 { get; set; }
        public string Md24 { get; set; }
        public string Md25 { get; set; }
        public string Md26 { get; set; }
        public string Md27 { get; set; }
        public string Md28 { get; set; }
        public string Md29 { get; set; }
        public string Md30 { get; set; }
        public string Md31 { get; set; }
        public string Md32 { get; set; }
        public string Md33 { get; set; }
        public string Md34 { get; set; }
        public string Md35 { get; set; }
        public string Md36 { get; set; }
        public string Md37 { get; set; }
        public string Md38 { get; set; }
        public string Md39 { get; set; }
        public string Md40 { get; set; }
        public string LvYn { get; set; }
        public string AllYn { get; set; }
        public string OtYn { get; set; }
        public string MealYn { get; set; }
        public string OtId1 { get; set; }
        public string OtId2 { get; set; }
        public string OtId3 { get; set; }
        public string OtBase1 { get; set; }
        public string OtBase2 { get; set; }
        public string OtBase3 { get; set; }
        public string LvBase1 { get; set; }
        public string LvBase2 { get; set; }
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

        public virtual Pr1set50 Adj { get; set; }
        public virtual Hm1com10 ComNoNavigation { get; set; }
        public virtual Hm1dept10 DeptNoNavigation { get; set; }
        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Hm1pos10 PosNoNavigation { get; set; }
        public virtual Pr1set40 SarAttrNavigation { get; set; }
        public virtual Pr1set70 SarCostNavigation { get; set; }
        public virtual Pr1set80 SarKindNavigation { get; set; }
    }
}
