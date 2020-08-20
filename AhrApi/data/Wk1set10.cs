using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Wk1set10
    {
        public Wk1set10()
        {
            Wk1mon10 = new HashSet<Wk1mon10>();
            Wk1wok10 = new HashSet<Wk1wok10>();
        }

        public string WkItem { get; set; }
        public string WkNm { get; set; }
        public string WkType { get; set; }
        public string PrNo { get; set; }
        public decimal? WkQty1 { get; set; }
        public decimal WkPrice1 { get; set; }
        public decimal WkAmt1 { get; set; }
        public decimal? WkQty2 { get; set; }
        public decimal WkPrice2 { get; set; }
        public decimal WkAmt2 { get; set; }
        public decimal? WkQty3 { get; set; }
        public decimal WkPrice3 { get; set; }
        public decimal WkAmt3 { get; set; }
        public decimal? WkQty4 { get; set; }
        public decimal WkPrice4 { get; set; }
        public decimal WkAmt4 { get; set; }
        public decimal? WkQty5 { get; set; }
        public decimal WkPrice5 { get; set; }
        public decimal WkAmt5 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public string WkFile { get; set; }

        public virtual ICollection<Wk1mon10> Wk1mon10 { get; set; }
        public virtual ICollection<Wk1wok10> Wk1wok10 { get; set; }
    }
}
