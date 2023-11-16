using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy04200
    {
        public short Cmtsries { get; set; }
        public string Commntid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
        public string Cmmttext { get; set; } = null!;
    }
}
