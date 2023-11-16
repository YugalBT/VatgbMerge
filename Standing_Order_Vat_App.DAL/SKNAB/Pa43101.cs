using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa43101
    {
        public string PaBillFormatNumber { get; set; } = null!;
        public string Pabillformname { get; set; } = null!;
        public byte Pacbdefault { get; set; }
        public int DexRowId { get; set; }
    }
}
