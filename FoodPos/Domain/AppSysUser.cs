using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppSysUser
    {
        public AppSysUser()
        {
            AppSysRoleUser = new HashSet<AppSysRoleUser>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string MainPhoto { get; set; }
        public string UserData { get; set; }
        public bool? IsOnOff { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? LoginDate { get; set; }
        public int? LoginErrors { get; set; }
        public DateTime? LoginLastDate { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<AppSysRoleUser> AppSysRoleUser { get; set; }
    }
}
