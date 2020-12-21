using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class AppUser
    {
        public AppUser()
        {
            AppRoleUser = new HashSet<AppRoleUser>();
        }

        public int UserId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MainPhoto { get; set; }
        public string UserData { get; set; }
        public bool? IsOffUser { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int? LoginErrors { get; set; }
        public DateTime? LoginDate { get; set; }
        public DateTime? LoginLastDate { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual UserData UserDataNavigation { get; set; }
        public virtual ICollection<AppRoleUser> AppRoleUser { get; set; }
    }
}
