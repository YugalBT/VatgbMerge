using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Glaccount
    {
        public int IdGl { get; set; }
        public int IdCompany { get; set; }
        public int IdGroup { get; set; }
        public int IdGlMstrtyp { get; set; }
        public int IdGlSubtyp { get; set; }
        public int AcGl { get; set; }
        public bool Deleted { get; set; }

        public virtual Company IdCompanyNavigation { get; set; } = null!;
        public virtual EmployeeGroup IdGroupNavigation { get; set; } = null!;
    }
}
