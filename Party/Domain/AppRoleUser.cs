﻿using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class AppRoleUser
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public bool IsPermit { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual AppRole Role { get; set; }
        public virtual AppUser User { get; set; }
    }
}