using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp400000
    {
        public string Bchsourc { get; set; } = null!;
        public short Series { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Bchcomnt { get; set; } = null!;
        public short Bchsttus { get; set; }
        public byte Mkdtopst { get; set; }
        public int Numoftrx { get; set; }
        public decimal Bchtotal { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string Userid { get; set; } = null!;
        public byte[] Bchemsg1 { get; set; } = null!;
        public byte[] Bchemsg2 { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
