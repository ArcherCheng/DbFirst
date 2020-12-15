using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartyMatches
    {
        public int Partyid { get; set; }
        public int? TotalMatchs { get; set; }
        public int? TotalVotes { get; set; }
    }
}
