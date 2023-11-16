using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40100
    {
        public string Rprtname { get; set; } = null!;
        public short Reportid { get; set; }
        public short Rprttype { get; set; }
        public short Clcfrprt { get; set; }
        public short Lstmodif { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
