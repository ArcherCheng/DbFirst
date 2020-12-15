using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class AppUser
    {
        public AppUser()
        {
            AppRoleUser = new HashSet<AppRoleUser>();
            PartyUser = new HashSet<PartyUser>();
            PartyUserMsgRecipient = new HashSet<PartyUserMsg>();
            PartyUserMsgSender = new HashSet<PartyUserMsg>();
            PartyVoteLiker = new HashSet<PartyVote>();
            PartyVoteVote = new HashSet<PartyVote>();
            UserMsgRecipient = new HashSet<UserMsg>();
            UserMsgSender = new HashSet<UserMsg>();
            UserPhoto = new HashSet<UserPhoto>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Sex { get; set; }
        public int BirthYear { get; set; }
        public int Marry { get; set; }
        public int Education { get; set; }
        public int Heights { get; set; }
        public int Weights { get; set; }
        public int Salary { get; set; }
        public string Blood { get; set; }
        public string Star { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string School { get; set; }
        public string Subjects { get; set; }
        public string JobType { get; set; }
        public string Religion { get; set; }
        public string Introduction { get; set; }
        public string LikeCondition { get; set; }
        public bool IsCloseData { get; set; }
        public bool IsClosePhoto { get; set; }
        public string BankName { get; set; }
        public string BankNumber6 { get; set; }
        public string PhoneCode { get; set; }
        public string EmailCode { get; set; }
        public string IdPhoto11Url { get; set; }
        public string IdPhoto12Url { get; set; }
        public string JobPhotoUrl { get; set; }
        public string SchoolUrl { get; set; }
        public bool IsBlackUser { get; set; }
        public int UnPayTimes { get; set; }
        public int ResetPassword { get; set; }
        public int JobCheck { get; set; }
        public int IdCheck { get; set; }
        public int SchoolCheck { get; set; }
        public string MainPhotoUrl { get; set; }
        public string UserData { get; set; }
        public bool? IsOffUser { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? LoginDate { get; set; }
        public int? LoginErrors { get; set; }
        public DateTime? LoginLastDate { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual UserCondition UserCondition { get; set; }
        public virtual ICollection<AppRoleUser> AppRoleUser { get; set; }
        public virtual ICollection<PartyUser> PartyUser { get; set; }
        public virtual ICollection<PartyUserMsg> PartyUserMsgRecipient { get; set; }
        public virtual ICollection<PartyUserMsg> PartyUserMsgSender { get; set; }
        public virtual ICollection<PartyVote> PartyVoteLiker { get; set; }
        public virtual ICollection<PartyVote> PartyVoteVote { get; set; }
        public virtual ICollection<UserMsg> UserMsgRecipient { get; set; }
        public virtual ICollection<UserMsg> UserMsgSender { get; set; }
        public virtual ICollection<UserPhoto> UserPhoto { get; set; }
    }
}
