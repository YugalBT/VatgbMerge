using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa42602
    {
        public short PabillFormatKey { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Prnset { get; set; } = null!;
    }
}
