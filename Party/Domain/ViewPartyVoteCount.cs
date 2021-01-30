using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartyVoteCount
    {
        public int PartyId { get; set; }
        public int Likerid { get; set; }
        public int? Sex { get; set; }
        public int? Counts { get; set; }
    }
}
