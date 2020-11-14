using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppSysRolePermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public bool IsPermit { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual AppSysPermission Permission { get; set; }
        public virtual AppSysRole Role { get; set; }
    }
}
