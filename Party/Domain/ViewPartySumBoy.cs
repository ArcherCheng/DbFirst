using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartySumBoy
    {
        public int PartyId { get; set; }
        public int? TotalBoys { get; set; }
        public int? BoyAges { get; set; }
    }
}
