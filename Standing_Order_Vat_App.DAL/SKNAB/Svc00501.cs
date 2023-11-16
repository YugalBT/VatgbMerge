using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00501
    {
        public string Itemnmbr { get; set; } = null!;
        public short Itemtype { get; set; }
        public string Itemdesc { get; set; } = null!;
        public string Itmshnam { get; set; } = null!;
        public short Itmtrkop { get; set; }
        public decimal Listprce { get; set; }
        public byte Rtrnable { get; set; }
        public byte Metered { get; set; }
        public short SvcDeltaType { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
