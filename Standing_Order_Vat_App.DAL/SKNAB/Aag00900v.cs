using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00900v
    {
        public short AaFiscalPeriod { get; set; }
        public decimal RootBalance { get; set; }
        public decimal RootQty { get; set; }
        public decimal? FirstBalance { get; set; }
        public decimal? FirstQty { get; set; }
        public decimal? DiffAmount { get; set; }
        public decimal? DiffQty { get; set; }
        public int DexRowId { get; set; }
    }
}
