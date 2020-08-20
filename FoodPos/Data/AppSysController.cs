using System;
using System.Collections.Generic;

namespace DbFirst.FoodPos.Data
{
    public partial class AppSysController
    {
        public AppSysController()
        {
            AppSysRoleController = new HashSet<AppSysRoleController>();
        }

        public int ControllerId { get; set; }
        public string ControllerName { get; set; }
        public string Descriptions { get; set; }
        public string Actions { get; set; }
        public string AppSystem { get; set; }
        public DateTime? WriteTime { get; set; }
        public string WriteUser { get; set; }
        public string WriteIp { get; set; }

        public virtual ICollection<AppSysRoleController> AppSysRoleController { get; set; }
    }
}
