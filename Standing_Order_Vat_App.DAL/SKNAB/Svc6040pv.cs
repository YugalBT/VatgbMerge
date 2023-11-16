using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc6040pv
    {
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public int? DexRowId { get; set; }
        public decimal? NetTransactionAmount { get; set; }
        public decimal? OrigNetTransactionAmount { get; set; }
    }
}
