using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ot1ovt10
    {
        public string EmpNo { get; set; }
        public string Sdate { get; set; }
        public string Smon { get; set; }
        public string Stime1 { get; set; }
        public string Stime2 { get; set; }
        public string OtId { get; set; }
        public decimal OtHr { get; set; }
        public string Note1 { get; set; }
        public string OtCd { get; set; }
        public string OtlvYn { get; set; }
        public decimal OtHr1 { get; set; }
        public decimal OtHr2 { get; set; }
        public decimal OtHr3 { get; set; }
        public decimal OtAmt { get; set; }
        public decimal OtAmt1 { get; set; }
        public decimal OtAmt2 { get; set; }
        public string DutyNo { get; set; }
        public decimal DutyAmt { get; set; }
        public decimal OtlvHr { get; set; }
        public decimal SubHr { get; set; }
        public string AdjYn { get; set; }
        public string ChkId1 { get; set; }
        public string ChkId2 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Ot1set10 Ot { get; set; }
        public virtual Ot1set20 OtCdNavigation { get; set; }
    }
}
