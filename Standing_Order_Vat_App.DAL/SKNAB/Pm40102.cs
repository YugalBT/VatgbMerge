using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm40102
    {
        public short Doctype { get; set; }
        public string Docabrev { get; set; } = null!;
        public string Doctynam { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
