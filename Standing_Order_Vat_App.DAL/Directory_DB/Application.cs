using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class Application
    {
        public Application()
        {
            ApplicationDataFilters = new HashSet<ApplicationDataFilter>();
            ApplicationModules = new HashSet<ApplicationModule>();
            ApplicationRoles = new HashSet<ApplicationRole>();
        }

        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; } = null!;
        /// <summary>
        /// web address of the  application
        /// </summary>
        public string Uri { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string? GroupName { get; set; }
        public string? Path { get; set; }

        public virtual ICollection<ApplicationDataFilter> ApplicationDataFilters { get; set; }
        public virtual ICollection<ApplicationModule> ApplicationModules { get; set; }
        public virtual ICollection<ApplicationRole> ApplicationRoles { get; set; }
    }
}
