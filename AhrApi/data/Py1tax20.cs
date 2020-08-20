using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Py1tax20
    {
        public string Syear { get; set; }
        public string EmpNo { get; set; }
        public string TaxCd { get; set; }
        public string TaxFg { get; set; }
        public decimal? SeqNo { get; set; }
        public decimal? PayAmt { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? NetAmt { get; set; }
        public string AdjYn { get; set; }
        public string TaxYn { get; set; }
        public string ShareData1 { get; set; }
        public string ShareData2 { get; set; }
        public decimal? PenAmt1 { get; set; }
        public decimal? Salary01 { get; set; }
        public decimal? SalaryTax01 { get; set; }
        public decimal? Salary02 { get; set; }
        public decimal? SalaryTax02 { get; set; }
        public decimal? Salary03 { get; set; }
        public decimal? SalaryTax03 { get; set; }
        public decimal? Salary04 { get; set; }
        public decimal? SalaryTax04 { get; set; }
        public decimal? Salary05 { get; set; }
        public decimal? SalaryTax05 { get; set; }
        public decimal? Salary06 { get; set; }
        public decimal? SalaryTax06 { get; set; }
        public decimal? Salary07 { get; set; }
        public decimal? SalaryTax07 { get; set; }
        public decimal? Salary08 { get; set; }
        public decimal? SalaryTax08 { get; set; }
        public decimal? Salary09 { get; set; }
        public decimal? SalaryTax09 { get; set; }
        public decimal? Salary10 { get; set; }
        public decimal? SalaryTax10 { get; set; }
        public decimal? Salary11 { get; set; }
        public decimal? SalaryTax11 { get; set; }
        public decimal? Salary12 { get; set; }
        public decimal? SalaryTax12 { get; set; }
        public decimal? Bonus01 { get; set; }
        public decimal? BonusTax01 { get; set; }
        public decimal? Bonus02 { get; set; }
        public decimal? BonusTax02 { get; set; }
        public decimal? Bonus03 { get; set; }
        public decimal? BonusTax03 { get; set; }
        public decimal? Bonus04 { get; set; }
        public decimal? BonusTax04 { get; set; }
        public decimal? Bonus05 { get; set; }
        public decimal? BonusTax05 { get; set; }
        public decimal? Bonus06 { get; set; }
        public decimal? BonusTax06 { get; set; }
        public decimal? Bonus07 { get; set; }
        public decimal? BonusTax07 { get; set; }
        public decimal? Bonus08 { get; set; }
        public decimal? BonusTax08 { get; set; }
        public decimal? Bonus09 { get; set; }
        public decimal? BonusTax09 { get; set; }
        public decimal? Bonus10 { get; set; }
        public decimal? BonusTax10 { get; set; }
        public decimal? Bonus11 { get; set; }
        public decimal? BonusTax11 { get; set; }
        public decimal? Bonus12 { get; set; }
        public decimal? BonusTax12 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Py1set10 TaxCdNavigation { get; set; }
        public virtual Py1set40 TaxFgNavigation { get; set; }
    }
}
