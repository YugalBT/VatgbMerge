using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl10001
    {
        public string Bachnumb { get; set; } = null!;
        public int Jrnentry { get; set; }
        public decimal Sqncline { get; set; }
        public int Actindx { get; set; }
        public decimal Xchgrate { get; set; }
        public string Dscriptn { get; set; } = null!;
        public byte[] Gllinmsg { get; set; } = null!;
        public byte[] Gllinms2 { get; set; } = null!;
        public short Currnidx { get; set; }
        public byte[] Gllinval { get; set; } = null!;
        public short Accttype { get; set; }
        public short Fxdorvar { get; set; }
        public short Balfrclc { get; set; }
        public short Pstngtyp { get; set; }
        public short Decplacs { get; set; }
        public string Orctrnum { get; set; } = null!;
        public string Ordocnum { get; set; } = null!;
        public string Ormstrid { get; set; } = null!;
        public string Ormstrnm { get; set; } = null!;
        public short Ortrxtyp { get; set; }
        public int OrigSeqNum { get; set; }
        public string Ortrxdesc { get; set; } = null!;
        public short DtaGlStatus { get; set; }
        public string Interid { get; set; } = null!;
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public short Lnestat { get; set; }
        public string CorrespondingUnit { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
