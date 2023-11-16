using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm80100
    {
        public string Trxsorce { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public int Numoftrx { get; set; }
        public short Recpstgs { get; set; }
        public short Mscbdinc { get; set; }
        public short Bachfreq { get; set; }
        public short Nofpstgs { get; set; }
        public string Bchcomnt { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public byte Rcdsrmvd { get; set; }
        public decimal Bchtotal { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
