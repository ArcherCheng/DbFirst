﻿using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class UserPhoto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsMain { get; set; }
        public string Descriptions { get; set; }
        public string PhotoUrl { get; set; }
        public string PublicId { get; set; }
        public int WriteUserId { get; set; }
        public int WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual UserData User { get; set; }
    }
}
