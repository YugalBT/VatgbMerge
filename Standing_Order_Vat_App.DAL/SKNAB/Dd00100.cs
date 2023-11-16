using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd00100
    {
        public string Employid { get; set; } = null!;
        public byte Inactive { get; set; }
        public short Ddremain { get; set; }
        public short Index1 { get; set; }
        public int DexRowId { get; set; }
    }
}
