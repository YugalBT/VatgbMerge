using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationDataFilter
    {
        public ApplicationDataFilter()
        {
            ApplicationUserDataFilters = new HashSet<ApplicationUserDataFilter>();
        }

        public int ApplicationFilterId { get; set; }
        public int ApplicationId { get; set; }
        public int FilterId { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual DataFilter Filter { get; set; } = null!;
        public virtual ICollection<ApplicationUserDataFilter> ApplicationUserDataFilters { get; set; }
    }
}
