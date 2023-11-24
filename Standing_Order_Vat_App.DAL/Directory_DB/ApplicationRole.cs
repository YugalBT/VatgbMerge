using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationRole
    {
        public ApplicationRole()
        {
            ApplicationRoleModules = new HashSet<ApplicationRoleModule>();
        }

        public int ApplicationRoleId { get; set; }
        public int RoleId { get; set; }
        public int ApplicationId { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<ApplicationRoleModule> ApplicationRoleModules { get; set; }
    }
}
