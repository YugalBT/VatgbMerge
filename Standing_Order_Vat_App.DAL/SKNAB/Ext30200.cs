using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext30200
    {
        public string WarningId { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Userid { get; set; } = null!;
        public short ResponseNumber { get; set; }
        public string ResponseString { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
    }
}
