using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30100
    {
        public string Trxsorce { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchcomnt { get; set; } = null!;
        public short Bachfreq { get; set; }
        public DateTime Posteddt { get; set; }
        public byte Histrmvd { get; set; }
        public decimal Bchtotal { get; set; }
        public decimal Cntrltot { get; set; }
        public int Numoftrx { get; set; }
        public int Cntrltrx { get; set; }
        public int DexRowId { get; set; }
    }
}
