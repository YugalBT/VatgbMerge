using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10109
    {
        public string Prcbkid { get; set; } = null!;
        public string Descexpr { get; set; } = null!;
        public byte Isbase { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
