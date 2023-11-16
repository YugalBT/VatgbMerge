using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40109
    {
        public string Fldprnam { get; set; } = null!;
        public int DexRowId { get; set; }
        public byte[] Fldpctur { get; set; } = null!;
    }
}
