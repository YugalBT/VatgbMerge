using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag50000
    {
        public string Userid { get; set; } = null!;
        public string Trxbtchsrc { get; set; } = null!;
        public int AaSubLedgerHdrId { get; set; }
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public DateTime Pstgdate { get; set; }
        public int AaOrder { get; set; }
        public int DexRowId { get; set; }
    }
}
