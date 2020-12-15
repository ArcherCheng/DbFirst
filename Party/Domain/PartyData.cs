using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class PartyData
    {
        public PartyData()
        {
            PartyPhoto = new HashSet<PartyPhoto>();
            PartyUser = new HashSet<PartyUser>();
            PartyVote = new HashSet<PartyVote>();
        }

        public int PartyId { get; set; }
        public string PartyName { get; set; }
        public DateTime PartyDate { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public int Marry { get; set; }
        public int BoyAmt { get; set; }
        public int BoyEducaton { get; set; }
        public int BoyAge1 { get; set; }
        public int BoyAge2 { get; set; }
        public int BoyPersons { get; set; }
        public int GirlAmt { get; set; }
        public int GirlEducaton { get; set; }
        public int GirlAge1 { get; set; }
        public int GirlAge2 { get; set; }
        public int GirlPersons { get; set; }
        public DateTime EarlyDate { get; set; }
        public int EarlyManAmt { get; set; }
        public int EarlyWomanAmt { get; set; }
        public int GirlsAmt { get; set; }
        public string PictureUrl { get; set; }
        public string Restaurant { get; set; }
        public string AddressNo { get; set; }
        public string BusNote { get; set; }
        public string Notes { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<PartyPhoto> PartyPhoto { get; set; }
        public virtual ICollection<PartyUser> PartyUser { get; set; }
        public virtual ICollection<PartyVote> PartyVote { get; set; }
    }
}
