using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class AppPermission
    {
        public AppPermission()
        {
            AppRolePermission = new HashSet<AppRolePermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionDesc { get; set; }
        public string HttpApi { get; set; }
        public string HttpMethod { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsExternal { get; set; }
        public string ExternalUrl { get; set; }

        public virtual ICollection<AppRolePermission> AppRolePermission { get; set; }
    }
}
