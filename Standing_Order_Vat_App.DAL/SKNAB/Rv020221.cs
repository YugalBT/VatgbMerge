using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rv020221
    {
        public string ReviewsetupcodeI { get; set; } = null!;
        public string ReviewcategoryI { get; set; } = null!;
        public short ReviewweightfactorI { get; set; }
        public short SeqorderI { get; set; }
        public int ReviewwordsetindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
