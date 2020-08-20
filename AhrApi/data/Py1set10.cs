using System;
using System.Collections.Generic;

namespace AhrApi.Data
{
    public partial class Py1set10
    {
        public Py1set10()
        {
            Bn1set10 = new HashSet<Bn1set10>();
            Py1oth10 = new HashSet<Py1oth10>();
            Py1oth20 = new HashSet<Py1oth20>();
            Py1oth30 = new HashSet<Py1oth30>();
            Py1tax10 = new HashSet<Py1tax10>();
            Py1tax20 = new HashSet<Py1tax20>();
            Py1tax30 = new HashSet<Py1tax30>();
        }

        public string TaxCd { get; set; }
        public string Note1 { get; set; }
        public string CrUser { get; set; }
        public DateTime? CrDate { get; set; }
        public string UpUser { get; set; }
        public DateTime? UpDate { get; set; }
        public byte? IdOver { get; set; }

        public virtual ICollection<Bn1set10> Bn1set10 { get; set; }
        public virtual ICollection<Py1oth10> Py1oth10 { get; set; }
        public virtual ICollection<Py1oth20> Py1oth20 { get; set; }
        public virtual ICollection<Py1oth30> Py1oth30 { get; set; }
        public virtual ICollection<Py1tax10> Py1tax10 { get; set; }
        public virtual ICollection<Py1tax20> Py1tax20 { get; set; }
        public virtual ICollection<Py1tax30> Py1tax30 { get; set; }
    }
}
