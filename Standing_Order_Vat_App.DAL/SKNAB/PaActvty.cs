using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class PaActvty
    {
        public string LockboxId { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public decimal Bchtotal { get; set; }
        public int Numoftrx { get; set; }
        public int NoOfTrxRejected { get; set; }
        public string Strng132 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
