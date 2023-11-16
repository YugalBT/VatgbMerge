using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Taac0230
    {
        public string AccrualI { get; set; } = null!;
        public string TimecodeI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
