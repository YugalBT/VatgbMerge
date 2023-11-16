using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10112
    {
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public int Ord { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime Time1 { get; set; }
        public short Sopstatus { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
