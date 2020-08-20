using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Aa1sql
    {
        public string SqlNote { get; set; }
        public string SqlExpl { get; set; }
        public string DwStyle { get; set; }
        public string PubYn { get; set; }
        public string ModifyYn { get; set; }
        public string SaveYn { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
    }
}
