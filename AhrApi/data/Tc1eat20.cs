using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Tc1eat20
    {
        public string CardStr { get; set; }
        public string TcfType { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual Tc1set20 TcfTypeNavigation { get; set; }
    }
}
