using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartyMatchUser
    {
        public int Partyid { get; set; }
        public int VoteId { get; set; }
        public int LikerId { get; set; }
    }
}
