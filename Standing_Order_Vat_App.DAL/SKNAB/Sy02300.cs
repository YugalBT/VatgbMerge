using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy02300
    {
        public short Upstdtfr { get; set; }
        public short Bchexist { get; set; }
        public byte Ptgenled { get; set; }
        public short Series { get; set; }
        public string Trxsourc { get; set; } = null!;
        public short Pstoglhw { get; set; }
        public byte Altrxpst { get; set; }
        public byte Autpstgl { get; set; }
        public byte Verbatot { get; set; }
        public byte Vertrx { get; set; }
        public byte Reqbaprv { get; set; }
        public string Password { get; set; } = null!;
        public byte Incmcinf { get; set; }
        public byte UseAccountSettings { get; set; }
        public int DexRowId { get; set; }
    }
}
