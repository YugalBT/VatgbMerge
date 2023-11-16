using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00112
    {
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Bin { get; set; } = null!;
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public decimal Atyalloc { get; set; }
        public int DexRowId { get; set; }
    }
}
