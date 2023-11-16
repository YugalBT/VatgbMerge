using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben07
    {
        public string Benefit { get; set; } = null!;
        public string EntrancedatesI { get; set; } = null!;
        public short WaitingperiodI { get; set; }
        public byte BonuselactiveI { get; set; }
        public int DexRowId { get; set; }
    }
}
