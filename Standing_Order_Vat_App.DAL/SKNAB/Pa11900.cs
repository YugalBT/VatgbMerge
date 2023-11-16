using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11900
    {
        public string Pacontnumber { get; set; } = null!;
        public int PaProjClosingSequence { get; set; }
        public int Lnitmseq { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
