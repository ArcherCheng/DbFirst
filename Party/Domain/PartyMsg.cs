using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class PartyMsg
    {
        public int Id { get; set; }
        public int PartyId { get; set; }
        public int UserId { get; set; }
        public string Contents { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }
    }
}
