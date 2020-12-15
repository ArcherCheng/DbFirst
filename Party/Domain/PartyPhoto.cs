using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class PartyPhoto
    {
        public int Id { get; set; }
        public int PartyId { get; set; }
        public string Descriptions { get; set; }
        public string PhotoUrl { get; set; }
        public string PublicId { get; set; }
        public bool? IsMain { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual PartyDate Party { get; set; }
    }
}
