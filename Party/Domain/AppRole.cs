using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class AppRole
    {
        public AppRole()
        {
            AppRolePermission = new HashSet<AppRolePermission>();
            AppRoleUser = new HashSet<AppRoleUser>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int? Priority { get; set; }
        public int? SortOrder { get; set; }
        public string Note1 { get; set; }

        public virtual ICollection<AppRolePermission> AppRolePermission { get; set; }
        public virtual ICollection<AppRoleUser> AppRoleUser { get; set; }
    }
}
