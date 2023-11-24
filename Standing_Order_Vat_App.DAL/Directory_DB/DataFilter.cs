using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class DataFilter
    {
        public DataFilter()
        {
            ApplicationDataFilters = new HashSet<ApplicationDataFilter>();
            UserDataFilters = new HashSet<UserDataFilter>();
        }

        public int FilterId { get; set; }
        public string FilterName { get; set; } = null!;

        public virtual ICollection<ApplicationDataFilter> ApplicationDataFilters { get; set; }
        public virtual ICollection<UserDataFilter> UserDataFilters { get; set; }
    }
}
