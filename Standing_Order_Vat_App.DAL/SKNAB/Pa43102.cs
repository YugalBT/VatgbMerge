using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa43102
    {
        public string PaBillFormatNumber { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short PabillFormatKey { get; set; }
        public int DexRowId { get; set; }
    }
}
