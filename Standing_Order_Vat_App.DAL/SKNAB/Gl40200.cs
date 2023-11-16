using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl40200
    {
        public short Sgmtnumb { get; set; }
        public string Sgmntid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public int Segcount { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
