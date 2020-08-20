using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1com10
    {
        public Hm1com10()
        {
            Pr1sar10 = new HashSet<Pr1sar10>();
        }

        public string ComNo { get; set; }
        public string ComNm { get; set; }
        public string ComCd { get; set; }
        public string LicenseCd { get; set; }
        public string OwnerNo { get; set; }
        public string OwnerNm { get; set; }
        public string TaxCd { get; set; }
        public string TaxLicenseCd { get; set; }
        public string TaxNo { get; set; }
        public string BureauNo { get; set; }
        public string HouseNo { get; set; }
        public string InsNo1 { get; set; }
        public string InsNo2 { get; set; }
        public string InsNo3 { get; set; }
        public string CompAddr { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string Operator { get; set; }
        public string Email { get; set; }
        public string Dns { get; set; }
        public byte? HrVersion { get; set; }
        public string Inifile { get; set; }
        public string Logofile { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Pr1sar10> Pr1sar10 { get; set; }
    }
}
