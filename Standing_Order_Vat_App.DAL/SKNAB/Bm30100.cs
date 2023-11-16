using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bm30100
    {
        public string Trxsorce { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bchcomnt { get; set; } = null!;
        public short Bachfreq { get; set; }
        public DateTime Pstgdate { get; set; }
        public int Numoftrx { get; set; }
        public decimal Bchtotal { get; set; }
        public decimal Noteindx { get; set; }
        public short Origin { get; set; }
        public byte Approvl { get; set; }
        public string Aprvluserid { get; set; } = null!;
        public DateTime Apprvldt { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public int DexRowId { get; set; }
    }
}
