using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00311
    {
        public int AaMlqueryId { get; set; }
        public short AaColumn { get; set; }
        public int AaOrder { get; set; }
        public byte AaTotals { get; set; }
        public byte AaPageBreak { get; set; }
        public byte AaUdfselect { get; set; }
        public int DexRowId { get; set; }
    }
}
