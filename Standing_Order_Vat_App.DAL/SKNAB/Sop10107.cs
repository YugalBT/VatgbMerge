using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10107
    {
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public string TrackingNumber { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
