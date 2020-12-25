using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartySumGirl
    {
        public int PartyId { get; set; }
        public int? TotalGirls { get; set; }
        public int? GirlAges { get; set; }
        public int? GirlEducation { get; set; }
        public int? GirlSalary { get; set; }
        public int? GirlHeights { get; set; }
        public int? GirlWeights { get; set; }
    }
}
