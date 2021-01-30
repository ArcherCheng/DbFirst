using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class PartyData
    {
        public PartyData()
        {
            PartyChat = new HashSet<PartyChat>();
            PartyPhoto = new HashSet<PartyPhoto>();
            PartySuggest = new HashSet<PartySuggest>();
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
        public int BoyEducation { get; set; }
        public int BoyAge1 { get; set; }
        public int BoyAge2 { get; set; }
        public int BoyPersons { get; set; }
        public int GirlAmt { get; set; }
        public int GirlEducation { get; set; }
        public int GirlAge1 { get; set; }
        public int GirlAge2 { get; set; }
        public int GirlPersons { get; set; }
        public DateTime EarlyDate { get; set; }
        public int EarlyBoyAmt { get; set; }
        public int EarlyGirlAmt { get; set; }
        public int TwoGirlsAmt { get; set; }
        public int MaxVote { get; set; }
        public string PictureUrl { get; set; }
        public string Restaurant { get; set; }
        public string AddressNo { get; set; }
        public string BusNote { get; set; }
        public string Notes { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<PartyChat> PartyChat { get; set; }
        public virtual ICollection<PartyPhoto> PartyPhoto { get; set; }
        public virtual ICollection<PartySuggest> PartySuggest { get; set; }
        public virtual ICollection<PartyUser> PartyUser { get; set; }
        public virtual ICollection<PartyVote> PartyVote { get; set; }
    }
}
