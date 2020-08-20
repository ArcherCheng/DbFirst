using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class AppSysRole
    {
        public AppSysRole()
        {
            AppSysRoleController = new HashSet<AppSysRoleController>();
            AppSysUser = new HashSet<AppSysUser>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int Priority { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<AppSysRoleController> AppSysRoleController { get; set; }
        public virtual ICollection<AppSysUser> AppSysUser { get; set; }
    }
}
