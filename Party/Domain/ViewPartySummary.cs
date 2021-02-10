using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartySummary
    {
        public int PartyId { get; set; }
        public string PartyName { get; set; }
        public DateTime PartyDate { get; set; }
        public string Restaurant { get; set; }
        public int Marry { get; set; }
        public int? TotalPersons { get; set; }
        public int? AvgAges { get; set; }
        public int? AvgEducation { get; set; }
        public int? AvgSalary { get; set; }
        public int? AvgHeights { get; set; }
        public int? AvgWeights { get; set; }
        public int? TotalBoys { get; set; }
        public int? BoyAges { get; set; }
        public int? BoyEducation { get; set; }
        public int? BoySalary { get; set; }
        public int? BoyHeights { get; set; }
        public int? BoyWeights { get; set; }
        public int? TotalGirls { get; set; }
        public int? GirlAges { get; set; }
        public int? GirlEducation { get; set; }
        public int? GirlSalary { get; set; }
        public int? GirlHeights { get; set; }
        public int? GirlWeights { get; set; }
        public int? TotalChats { get; set; }
        public int? TotalVotes { get; set; }
        public int? TotalMatches { get; set; }
    }
}
