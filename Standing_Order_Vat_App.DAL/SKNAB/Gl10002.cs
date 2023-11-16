using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl10002
    {
        public string Bachnumb { get; set; } = null!;
        public int Jrnentry { get; set; }
        public int Actindx { get; set; }
        public decimal Sqncline { get; set; }
        public int Offindx { get; set; }
        public decimal Pstdamnt { get; set; }
        public byte[] Gllinmsg { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public byte[] Gllinval { get; set; } = null!;
        public short Accttype { get; set; }
        public short Decplacs { get; set; }
        public short Offactyp { get; set; }
        public short Offxvar { get; set; }
        public short Offblclc { get; set; }
        public short Offdecpl { get; set; }
        public int DexRowId { get; set; }
    }
}
