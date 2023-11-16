using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl50101
    {
        public string Userid { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public int Jrnentry { get; set; }
        public decimal Sqncline { get; set; }
        public int Actindx { get; set; }
        public int Offindx { get; set; }
        public byte[] Gllinmsg { get; set; } = null!;
        public byte[] Gllinms2 { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public short Accttype { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public short Funcridx { get; set; }
        public string Interid { get; set; } = null!;
        public string Actnumst { get; set; } = null!;
        public string Actdescr { get; set; } = null!;
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string Orctrnum { get; set; } = null!;
        public string Ordocnum { get; set; } = null!;
        public string Ormstrid { get; set; } = null!;
        public string Ormstrnm { get; set; } = null!;
        public short Ortrxtyp { get; set; }
        public short Mctrxstt { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal Denxrate { get; set; }
        public int DexRowId { get; set; }
    }
}
