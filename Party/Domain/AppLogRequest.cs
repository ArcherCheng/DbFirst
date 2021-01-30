using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class AppLogRequest
    {
        public long Id { get; set; }
        public string Refer { get; set; }
        public string Destination { get; set; }
        public string QueryString { get; set; }
        public string Method { get; set; }
    }
}
