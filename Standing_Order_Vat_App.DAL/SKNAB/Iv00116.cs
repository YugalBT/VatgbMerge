using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00116
    {
        public string Itemnmbr { get; set; } = null!;
        public byte PrintPhaseComp { get; set; }
        public int DexRowId { get; set; }
    }
}
