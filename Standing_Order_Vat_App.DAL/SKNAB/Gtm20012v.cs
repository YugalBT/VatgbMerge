using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm20012v
    {
        public int AaTrxDimId { get; set; }
        public int AaTrxCodeId { get; set; }
        public string AaTrxDimCode { get; set; } = null!;
        public int Actindx { get; set; }
        public DateTime Glpostdt { get; set; }
        public decimal? NetAmount { get; set; }
        public int DexRowId { get; set; }
    }
}
