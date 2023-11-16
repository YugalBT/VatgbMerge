using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc00300
    {
        public int Actindx { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Hstrclrt { get; set; }
        public int DexRowId { get; set; }
    }
}
