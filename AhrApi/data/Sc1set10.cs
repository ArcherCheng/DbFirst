using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Sc1set10
    {
        public Sc1set10()
        {
            Sc1cod10 = new HashSet<Sc1cod10>();
            Sc1mon10 = new HashSet<Sc1mon10>();
        }

        public string ScNo { get; set; }
        public string PosLev1 { get; set; }
        public string PosLev2 { get; set; }
        public string ScDesc { get; set; }
        public string ScTitle1 { get; set; }
        public string ScTitle2 { get; set; }
        public string ScTitle3 { get; set; }
        public string ScTitle4 { get; set; }
        public string ScCat1 { get; set; }
        public string ScCat2 { get; set; }
        public string ScCat3 { get; set; }
        public string ScCat4 { get; set; }
        public string ScCat5 { get; set; }
        public string ScCat6 { get; set; }
        public string ScCat7 { get; set; }
        public string ScCat8 { get; set; }
        public string ScCat9 { get; set; }
        public string ScCat10 { get; set; }
        public string ScCat11 { get; set; }
        public string ScCat12 { get; set; }
        public string ScCat13 { get; set; }
        public string ScCat14 { get; set; }
        public string ScCat15 { get; set; }
        public string ScCat16 { get; set; }
        public string ScCat17 { get; set; }
        public string ScCat18 { get; set; }
        public string ScCat19 { get; set; }
        public string ScCat20 { get; set; }
        public string ScCat21 { get; set; }
        public string ScCat22 { get; set; }
        public string ScCat23 { get; set; }
        public string ScCat24 { get; set; }
        public string ScCat25 { get; set; }
        public string ScNote1 { get; set; }
        public string ScNote2 { get; set; }
        public string ScNote3 { get; set; }
        public string ScNote4 { get; set; }
        public string ScNote5 { get; set; }
        public string ScNote6 { get; set; }
        public string ScNote7 { get; set; }
        public string ScNote8 { get; set; }
        public string ScNote9 { get; set; }
        public string ScNote10 { get; set; }
        public string ScNote11 { get; set; }
        public string ScNote12 { get; set; }
        public string ScNote13 { get; set; }
        public string ScNote14 { get; set; }
        public string ScNote15 { get; set; }
        public string ScNote16 { get; set; }
        public string ScNote17 { get; set; }
        public string ScNote18 { get; set; }
        public string ScNote19 { get; set; }
        public string ScNote20 { get; set; }
        public string ScNote21 { get; set; }
        public string ScNote22 { get; set; }
        public string ScNote23 { get; set; }
        public string ScNote24 { get; set; }
        public string ScNote25 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Sc1cod10> Sc1cod10 { get; set; }
        public virtual ICollection<Sc1mon10> Sc1mon10 { get; set; }
    }
}
