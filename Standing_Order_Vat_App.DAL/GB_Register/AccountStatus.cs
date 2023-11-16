using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class AccountStatus
    {
        public int AcctStatId { get; set; }
        public string AcctStatusDescription { get; set; } = null!;
    }
}
