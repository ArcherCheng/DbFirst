using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Ot1set20
    {
        public Ot1set20()
        {
            Ot1ovt10 = new HashSet<Ot1ovt10>();
            Ot1ovt20 = new HashSet<Ot1ovt20>();
        }

        public string OtCd { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Ot1ovt10> Ot1ovt10 { get; set; }
        public virtual ICollection<Ot1ovt20> Ot1ovt20 { get; set; }
    }
}
