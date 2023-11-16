using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa41900
    {
        public string Userid { get; set; } = null!;
        public int Assetindex { get; set; }
        public int Bookindx { get; set; }
        public decimal Ytddepramt { get; set; }
        public DateTime Deprfromdate { get; set; }
        public DateTime Deprtodate { get; set; }
        public short Fayear { get; set; }
        public short Faperiod { get; set; }
        public int DexRowId { get; set; }
    }
}
