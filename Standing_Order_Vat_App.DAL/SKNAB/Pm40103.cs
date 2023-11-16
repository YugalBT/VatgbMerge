using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm40103
    {
        public short Disttype { get; set; }
        public string Dsnmshrt { get; set; } = null!;
        public string Dsnmlong { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
