using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class Module
    {
        public Module()
        {
            ApplicationModules = new HashSet<ApplicationModule>();
        }

        public int ModuleId { get; set; }
        public string ModuleName { get; set; } = null!;

        public virtual ICollection<ApplicationModule> ApplicationModules { get; set; }
    }
}
