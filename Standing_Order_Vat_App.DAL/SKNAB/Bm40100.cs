using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bm40100
    {
        public short Setupkey { get; set; }
        public short DefaultDocumentDate { get; set; }
        public byte Kptrxhst { get; set; }
        public string TrxId { get; set; } = null!;
        public byte AllowQtyOverride { get; set; }
        public byte Allowserlotlinking { get; set; }
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Usrdrpr3 { get; set; } = null!;
        public string Usrdrpr4 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
