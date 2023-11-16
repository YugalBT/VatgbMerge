using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rv030221
    {
        public int ReviewwordsetindexI { get; set; }
        public short SeqorderI { get; set; }
        public string ReviewratingwordI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
