using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn01500
    {
        public string CollectorId { get; set; } = null!;
        public string CnSignatureId { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Signature { get; set; } = null!;
    }
}
