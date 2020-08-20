using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa4userDept
    {
        public string UserNo { get; set; }
        public string DeptNo { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
