using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrsax032
    {
        public short TableI { get; set; }
        public short RowI { get; set; }
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
