using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationUserModule
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int UserId { get; set; }
        public int ModuleId { get; set; }
        public string Permission { get; set; } = null!;

        public virtual ApplicationModule ApplicationModule { get; set; } = null!;
        public virtual ApplicationUserRole ApplicationUserRole { get; set; } = null!;
    }
}
