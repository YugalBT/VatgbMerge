using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc10120
    {
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public short Potype { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtycance { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public int Invindx { get; set; }
        public short Lineorigin { get; set; }
        public int DexRowId { get; set; }
    }
}
