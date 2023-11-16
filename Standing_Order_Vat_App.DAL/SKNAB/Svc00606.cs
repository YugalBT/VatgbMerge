using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00606
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
