using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00502
    {
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public short Rcrdtype { get; set; }
        public decimal Qtyonhnd { get; set; }
        public decimal Atyalloc { get; set; }
        public short SvcDeltaType { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
