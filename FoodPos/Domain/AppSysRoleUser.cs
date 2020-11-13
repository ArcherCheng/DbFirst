using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppSysRoleUser
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual AppSysRole Role { get; set; }
        public virtual AppSysUser User { get; set; }
    }
}
