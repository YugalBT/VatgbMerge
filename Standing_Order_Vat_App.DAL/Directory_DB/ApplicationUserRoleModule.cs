using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationUserRoleModule
    {
        public int UserRoleModuleId { get; set; }
        public int ApplicationId { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public int UserId { get; set; }

        public virtual ApplicationModule ApplicationModule { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
