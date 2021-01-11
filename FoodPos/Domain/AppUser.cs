using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppUser
    {
        public AppUser()
        {
            AppRoleUser = new HashSet<AppRoleUser>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }
        public string MainPhoto { get; set; }
        public int? ComId { get; set; }
        public string UserRole { get; set; }
        public string UserData { get; set; }
        public bool? IsOnOff { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? LoginDate { get; set; }
        public int? LoginErrors { get; set; }
        public DateTime? LoginLastDate { get; set; }

        public virtual ICollection<AppRoleUser> AppRoleUser { get; set; }
    }
}
