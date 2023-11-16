using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00312
    {
        public int AaMlqueryId { get; set; }
        public int AaColId { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaOrder { get; set; }
        public byte AaSubtotal { get; set; }
        public int AaBudgetId { get; set; }
        public byte AaTotal { get; set; }
        public int DexRowId { get; set; }
    }
}
