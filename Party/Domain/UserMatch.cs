using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class UserMatch
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MatchId { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual UserData Match { get; set; }
    }
}
