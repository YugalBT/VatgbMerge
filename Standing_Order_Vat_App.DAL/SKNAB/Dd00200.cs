using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd00200
    {
        public string Employid { get; set; } = null!;
        public short Index1 { get; set; }
        public byte Inactive { get; set; }
        public short Dednmthd { get; set; }
        public string Deducton { get; set; } = null!;
        public byte Ddpre { get; set; }
        public short Ddprecnt { get; set; }
        public short Ddpct { get; set; }
        public decimal Ddamtdlr { get; set; }
        public string Ddactnum { get; set; } = null!;
        public string Ddtranum { get; set; } = null!;
        public string Ddtrans { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
