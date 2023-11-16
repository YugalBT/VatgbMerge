using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm40601
    {
        public short Index1 { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Message { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
