using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05502
    {
        public string SvcRmaReasonCode { get; set; } = null!;
        public string SvcRmaReasonCodeDesc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
