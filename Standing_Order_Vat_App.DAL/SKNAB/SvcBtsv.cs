using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class SvcBtsv
    {
        public DateTime? Strtdate { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Callnbr { get; set; } = null!;
        public string? Svcdescr { get; set; }
        public decimal? Blktim { get; set; }
        public int? DexRowId { get; set; }
    }
}
