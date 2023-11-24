using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class Role
    {
        public Role()
        {
            ApplicationRoles = new HashSet<ApplicationRole>();
            ApplicationUserRoleModules = new HashSet<ApplicationUserRoleModule>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<ApplicationRole> ApplicationRoles { get; set; }
        public virtual ICollection<ApplicationUserRoleModule> ApplicationUserRoleModules { get; set; }
    }
}
