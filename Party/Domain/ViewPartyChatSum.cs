using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class ViewPartyChatSum
    {
        public int PartyId { get; set; }
        public int? TotalChats { get; set; }
    }
}
