using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm30502
    {
        public decimal Noteindx { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public byte Reprntnt { get; set; }
        public byte Trxmisng { get; set; }
        public string Chekbkid { get; set; } = null!;
        public int Numoftrx { get; set; }
        public short Bachfreq { get; set; }
        public string Bchcomnt { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; } = null!;
        public decimal Cntrltot { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Bchtotal { get; set; }
        public int DexRowId { get; set; }
    }
}
