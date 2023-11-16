using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01406
    {
        public string ParateTableId { get; set; } = null!;
        public string Padescription { get; set; } = null!;
        public DateTime ParateTableDate { get; set; }
        public byte Painactive { get; set; }
        public short PaprofitType { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
