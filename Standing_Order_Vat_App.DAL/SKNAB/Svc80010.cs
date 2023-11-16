using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc80010
    {
        public string Serlnmbr { get; set; } = null!;
        public string Pmdtlid { get; set; } = null!;
        public string Schedid { get; set; } = null!;
        public string Callnbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal Parstotprc { get; set; }
        public decimal Labstotprc { get; set; }
        public decimal Parstotcst { get; set; }
        public decimal Labstotcst { get; set; }
        public byte Marked { get; set; }
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int DexRowId { get; set; }
    }
}
