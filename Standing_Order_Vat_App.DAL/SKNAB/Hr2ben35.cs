using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben35
    {
        public short I2I { get; set; }
        public byte Check1I { get; set; }
        public byte Check2I { get; set; }
        public string ManagerI { get; set; } = null!;
        public string TitlelineI { get; set; } = null!;
        public DateTime IdateI { get; set; }
        public int DexRowId { get; set; }
        public string Comments1I { get; set; } = null!;
        public string Comments2I { get; set; } = null!;
    }
}
