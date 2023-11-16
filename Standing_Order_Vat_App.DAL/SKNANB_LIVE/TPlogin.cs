using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class TPlogin
    {
        public string UserName { get; set; } = null!;
        public string? Password { get; set; }
        /// <summary>
        /// There are three levels, 1 (Admin), 2(User), 3(Viewer)
        /// </summary>
        public int AccessLevel { get; set; }
    }
}
