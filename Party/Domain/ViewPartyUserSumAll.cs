using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartyUserSumAll
    {
        public int PartyId { get; set; }
        public int? TotalPersons { get; set; }
        public int? AvgAges { get; set; }
    }
}
