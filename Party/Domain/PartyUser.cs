using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class PartyUser
    {
        public int Id { get; set; }
        public int PartyId { get; set; }
        public int UserId { get; set; }
        public DateTime ApplyDate { get; set; }
        public int PartyAmt { get; set; }
        public bool IsWaiting { get; set; }
        public string BankName { get; set; }
        public string BankNumber6 { get; set; }
        public string BankDate { get; set; }
        public string FriendsName { get; set; }
        public bool IsBankCheck { get; set; }
        public string BankNote { get; set; }
        public int SeatNo { get; set; }
        public bool CheckOver { get; set; }
        public string Notes { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual PartyData Party { get; set; }
        public virtual UserData User { get; set; }
    }
}
