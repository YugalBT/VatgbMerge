using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class AtmDescription
    {
        public int Terminal { get; set; }
        public string TerminalName { get; set; } = null!;
        public int Type { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string Driver { get; set; } = null!;
        public string Function { get; set; } = null!;
        public string? CommAdd { get; set; }
        public long? MessageMode { get; set; }
        public DateTime OperationDate { get; set; }
    }
}
