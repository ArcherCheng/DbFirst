using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Pr1set20
    {
        public Pr1set20()
        {
            Pr1set21 = new HashSet<Pr1set21>();
            Pr1set22 = new HashSet<Pr1set22>();
            Pr1set23 = new HashSet<Pr1set23>();
        }

        public string BnkNo { get; set; }
        public string BnkNm { get; set; }
        public string BnkFile { get; set; }
        public string Staff { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Note1 { get; set; }
        public decimal? BnkAccp1 { get; set; }
        public decimal? BnkAccp2 { get; set; }
        public string CstEvent { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }
        public string BnkType { get; set; }

        public virtual ICollection<Pr1set21> Pr1set21 { get; set; }
        public virtual ICollection<Pr1set22> Pr1set22 { get; set; }
        public virtual ICollection<Pr1set23> Pr1set23 { get; set; }
    }
}
