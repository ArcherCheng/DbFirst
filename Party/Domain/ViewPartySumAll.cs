using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartySumAll
    {
        public int PartyId { get; set; }
        public int? TotalPersons { get; set; }
        public int? AvgAges { get; set; }
        public int? AvgEducation { get; set; }
        public int? AvgSalary { get; set; }
        public int? AvgHeights { get; set; }
        public int? AvgWeights { get; set; }
    }
}
