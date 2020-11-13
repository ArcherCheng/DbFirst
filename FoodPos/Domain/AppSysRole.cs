using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppSysRole
    {
        public AppSysRole()
        {
            AppSysRolePermission = new HashSet<AppSysRolePermission>();
            AppSysRoleUser = new HashSet<AppSysRoleUser>();
            InverseParent = new HashSet<AppSysRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int Priority { get; set; }
        public int? ParentId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual AppSysRole Parent { get; set; }
        public virtual ICollection<AppSysRolePermission> AppSysRolePermission { get; set; }
        public virtual ICollection<AppSysRoleUser> AppSysRoleUser { get; set; }
        public virtual ICollection<AppSysRole> InverseParent { get; set; }
    }
}
