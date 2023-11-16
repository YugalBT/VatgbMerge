using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class AttSecurity
    {
        public int IdEmployee { get; set; }
        public bool InRead { get; set; }
        public bool InWrite { get; set; }
        public bool InDelete { get; set; }
        public int Key { get; set; }
    }
}
