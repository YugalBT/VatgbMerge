using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40203
    {
        public short Reportid { get; set; }
        public short Rownmbr { get; set; }
        public string Rnge { get; set; } = null!;
        public byte Oldrow { get; set; }
        public int DexRowId { get; set; }
    }
}
