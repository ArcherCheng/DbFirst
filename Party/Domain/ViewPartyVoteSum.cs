using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartyVoteSum
    {
        public int Partyid { get; set; }
        public int? TotalVotes { get; set; }
    }
}
