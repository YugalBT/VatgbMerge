using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr41401
    {
        public string Localtax { get; set; } = null!;
        public short Txtblseq { get; set; }
        public decimal Txbrulmt { get; set; }
        public decimal Txbrktam { get; set; }
        public int Rxbrktrt { get; set; }
        public decimal Txbrexwg { get; set; }
        public int DexRowId { get; set; }
    }
}
