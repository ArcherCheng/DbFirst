using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartySumBoy
    {
        public int PartyId { get; set; }
        public int? TotalBoys { get; set; }
        public int? BoyAges { get; set; }
        public int? BoyEducation { get; set; }
        public int? BoySalary { get; set; }
        public int? BoyHeights { get; set; }
        public int? BoyWeights { get; set; }
    }
}
