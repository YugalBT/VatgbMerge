using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr00501
    {
        public string Employid { get; set; } = null!;
        public string Deducton { get; set; } = null!;
        public string Bsdoncde { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
