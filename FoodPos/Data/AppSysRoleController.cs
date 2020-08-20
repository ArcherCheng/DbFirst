using System;
using System.Collections.Generic;

namespace FoodPos.Data
{
    public partial class AppSysRoleController
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ControllerId { get; set; }
        public string DenyActions { get; set; }
        public string PermitActions { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual AppSysController Controller { get; set; }
        public virtual AppSysRole Role { get; set; }
    }
}
