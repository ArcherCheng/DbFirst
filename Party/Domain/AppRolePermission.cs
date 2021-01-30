using System;
using System.Collections.Generic;

namespace JustDo.Party.Domain
{
    public partial class AppRolePermission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public bool IsPermit { get; set; }

        public virtual AppPermission Permission { get; set; }
        public virtual AppRole Role { get; set; }
    }
}
