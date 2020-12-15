using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartyUserSumGirl
    {
        public int PartyId { get; set; }
        public int? TotalGirls { get; set; }
        public int? GirlAges { get; set; }
    }
}
