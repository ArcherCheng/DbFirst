using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class PartyVote
    {
        public int PartyId { get; set; }
        public int VoteId { get; set; }
        public int LikerId { get; set; }
        public DateTime VoteDate { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual AppUser Liker { get; set; }
        public virtual PartyData Party { get; set; }
        public virtual AppUser Vote { get; set; }
    }
}
