using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa30600
    {
        public string Papurordnum { get; set; } = null!;
        public byte Hold { get; set; }
        public string Holdremoveby { get; set; } = null!;
        public DateTime Holdremovedate { get; set; }
        public decimal Noteindx { get; set; }
        public string Onholdby { get; set; } = null!;
        public DateTime Onholddate { get; set; }
        public decimal Onordamt { get; set; }
        public decimal Orordamt { get; set; }
        public short Papodeformatouse { get; set; }
        public string Palastprtby { get; set; } = null!;
        public short PaTradeDiscountPcnt { get; set; }
        public string RegKey { get; set; } = null!;
        public short Trxtype { get; set; }
        public short Useadvtx { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Cmmttext { get; set; } = null!;
    }
}
