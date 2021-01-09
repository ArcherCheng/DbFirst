using System;
using System.Collections.Generic;

namespace FoodPos.Domain
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
        public int? SortNo { get; set; }
        public string Note1 { get; set; }
        public int? WriteComId { get; set; }
        public int? WriteUserId { get; set; }
        public int? WriteType { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<AppRolePermission> AppRolePermission { get; set; }
        public virtual ICollection<AppRoleUser> AppRoleUser { get; set; }
    }
}
