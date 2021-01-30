using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class PartySuggest
    {
        public int Id { get; set; }
        public int PartyId { get; set; }
        public int UserId { get; set; }
        public string Suggestion { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual PartyData Party { get; set; }
        public virtual UserData User { get; set; }
    }
}
