using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class SupportFilterMap
    {
        public int ApplicationId { get; set; }
        public int UserId { get; set; }
        public int FilterId { get; set; }
        public string Permission { get; set; } = null!;
    }
}
