using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10600
    {
        public string Papurordnum { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Papodeformatouse { get; set; }
        public short PafreightTaxableP { get; set; }
        public string Palastprtby { get; set; } = null!;
        public short PamiscTaxableP { get; set; }
        public short PaTradeDiscountPcnt { get; set; }
        public string RegKey { get; set; } = null!;
        public short Trxtype { get; set; }
        public short Useadvtx { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
