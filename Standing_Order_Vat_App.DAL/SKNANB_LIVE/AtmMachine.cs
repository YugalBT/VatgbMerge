using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class AtmMachine
    {
        public string MachineName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string IpAddress { get; set; } = null!;
        public int Number { get; set; }
        public string? NetworkName { get; set; }
    }
}
