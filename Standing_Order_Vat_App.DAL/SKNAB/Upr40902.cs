using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40902
    {
        public string Deducton { get; set; } = null!;
        public short Dednsqnc { get; set; }
        public int DexRowId { get; set; }
    }
}
