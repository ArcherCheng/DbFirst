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
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int? DisplayOrder { get; set; }
        public string Note1 { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<AppSysRolePermission> AppSysRolePermission { get; set; }
        public virtual ICollection<AppSysRoleUser> AppSysRoleUser { get; set; }
    }
}
