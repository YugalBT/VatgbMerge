using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10104
    {
        public short Rptngyr { get; set; }
        public string Employid { get; set; } = null!;
        public string Spclcode { get; set; } = null!;
        public short Spclbnum { get; set; }
        public decimal Spclamnt { get; set; }
        public byte W2printd { get; set; }
        public int DexRowId { get; set; }
    }
}
