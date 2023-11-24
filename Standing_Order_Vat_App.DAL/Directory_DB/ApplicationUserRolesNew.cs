using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationUserRolesNew
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }

        public virtual ApplicationRolesNew? Role { get; set; }
        public virtual User? User { get; set; }
    }
}
