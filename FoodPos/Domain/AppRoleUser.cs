using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppRoleUser
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public bool IsPermit { get; set; }

        public virtual AppRole Role { get; set; }
        public virtual AppUser User { get; set; }
    }
}
