using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class AppSysUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string MainPhotoUrl { get; set; }
        public bool? IsOnOff { get; set; }
        public int? RoleId { get; set; }
        public string UserData { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? LoginDate { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual AppSysRole Role { get; set; }
    }
}
