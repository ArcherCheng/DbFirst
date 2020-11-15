using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppSysPermission
    {
        public AppSysPermission()
        {
            AppSysRolePermission = new HashSet<AppSysRolePermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionDesc { get; set; }
        public string HttpApi { get; set; }
        public string HttpMethod { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int? SortNo { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsExternal { get; set; }
        public string ExternalUrl { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<AppSysRolePermission> AppSysRolePermission { get; set; }
    }
}
