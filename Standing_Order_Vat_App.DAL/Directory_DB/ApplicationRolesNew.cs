using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationRolesNew
    {
        public ApplicationRolesNew()
        {
            ApplicationUserRolesNews = new HashSet<ApplicationUserRolesNew>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public bool? IsActive { get; set; }

        public virtual ICollection<ApplicationUserRolesNew> ApplicationUserRolesNews { get; set; }
    }
}
