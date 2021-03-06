﻿using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class UserData
    {
        public UserData()
        {
            PartyChatRecipient = new HashSet<PartyChat>();
            PartyChatSender = new HashSet<PartyChat>();
            PartySuggest = new HashSet<PartySuggest>();
            PartyUser = new HashSet<PartyUser>();
            PartyVoteLiker = new HashSet<PartyVote>();
            PartyVoteVote = new HashSet<PartyVote>();
            UserChatRecipient = new HashSet<UserChat>();
            UserChatSender = new HashSet<UserChat>();
            UserMatch = new HashSet<UserMatch>();
            UserPhoto = new HashSet<UserPhoto>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int BirthYear { get; set; }
        public int Sex { get; set; }
        public int Marry { get; set; }
        public int Education { get; set; }
        public int Heights { get; set; }
        public int Weights { get; set; }
        public string Blood { get; set; }
        public string Star { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string School { get; set; }
        public string Subjects { get; set; }
        public string JobType { get; set; }
        public string WorkType { get; set; }
        public string Religion { get; set; }
        public int? Salary { get; set; }
        public string Personality { get; set; }
        public string Technique { get; set; }
        public string Interest { get; set; }
        public string Activities { get; set; }
        public string Introduction { get; set; }
        public string LikeCondition { get; set; }
        public string BankName { get; set; }
        public string BankNumber6 { get; set; }
        public bool? IsOnOffData { get; set; }
        public bool? IsOnOffPhoto { get; set; }
        public string IdPhoto11Url { get; set; }
        public string IdPhoto12Url { get; set; }
        public string JobPhotoUrl { get; set; }
        public string SchoolUrl { get; set; }
        public string MainPhotoUrl { get; set; }
        public bool IsBlackUser { get; set; }
        public int UnPayTimes { get; set; }
        public int JobCheck { get; set; }
        public int IdCheck { get; set; }
        public int SchoolCheck { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual UserCondition UserCondition { get; set; }
        public virtual ICollection<PartyChat> PartyChatRecipient { get; set; }
        public virtual ICollection<PartyChat> PartyChatSender { get; set; }
        public virtual ICollection<PartySuggest> PartySuggest { get; set; }
        public virtual ICollection<PartyUser> PartyUser { get; set; }
        public virtual ICollection<PartyVote> PartyVoteLiker { get; set; }
        public virtual ICollection<PartyVote> PartyVoteVote { get; set; }
        public virtual ICollection<UserChat> UserChatRecipient { get; set; }
        public virtual ICollection<UserChat> UserChatSender { get; set; }
        public virtual ICollection<UserMatch> UserMatch { get; set; }
        public virtual ICollection<UserPhoto> UserPhoto { get; set; }
    }
}
