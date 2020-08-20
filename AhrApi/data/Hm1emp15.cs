using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Hm1emp15
    {
        public string EmpNo { get; set; }
        public string OutDate { get; set; }
        public string RetDate { get; set; }
        public string RetDate2 { get; set; }
        public string RetDate3 { get; set; }
        public string ForeDate2 { get; set; }
        public string OutId { get; set; }
        public string Note1 { get; set; }
        public string OutYn1 { get; set; }
        public string OutYn2 { get; set; }
        public string OutYn3 { get; set; }
        public string OutYn4 { get; set; }
        public string BackYn { get; set; }
        public string BackSdate { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Hm1emp10 EmpNoNavigation { get; set; }
        public virtual Hm1set15 Out { get; set; }
    }
}
