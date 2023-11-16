using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl10100
    {
        public string Bsnsfmid { get; set; } = null!;
        public int Jrnentry { get; set; }
        public string Curncyid { get; set; } = null!;
        public int Offindx { get; set; }
        public DateTime Trxdate { get; set; }
        public decimal Trxbalnc { get; set; }
        public short Pstgstus { get; set; }
        public string Lastuser { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public string Uswhpstd { get; set; } = null!;
        public decimal Pstdamnt { get; set; }
        public string Refrence { get; set; } = null!;
        public string Sourcdoc { get; set; } = null!;
        public decimal Sqncline { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte[] Glhdrmsg { get; set; } = null!;
        public byte[] Glhdrms2 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public byte[] Glhdrval { get; set; } = null!;
        public short Periodid { get; set; }
        public short Openyear { get; set; }
        public short Closedyr { get; set; }
        public int Errstate { get; set; }
        public byte Histrx { get; set; }
        public short Offactyp { get; set; }
        public short Offblclc { get; set; }
        public short Offxvar { get; set; }
        public short Offpstyp { get; set; }
        public DateTime Docdate { get; set; }
        public byte Voided { get; set; }
        public int DexRowId { get; set; }
    }
}
