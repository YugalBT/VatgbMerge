using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr00800
    {
        public string Employid { get; set; } = null!;
        public string Localtax { get; set; } = null!;
        public string Lclfgsts { get; set; } = null!;
        public byte Aulcltax { get; set; }
        public short Numofexm { get; set; }
        public byte Inactive { get; set; }
        public decimal Noteindx { get; set; }
        public decimal Adtllocwthdng { get; set; }
        public int DexRowId { get; set; }
    }
}
