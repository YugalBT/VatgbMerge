using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm40401
    {
        public short Rmdtypal { get; set; }
        public string Docdescr { get; set; } = null!;
        public string Docabrev { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Setupkey { get; set; }
        public int DexRowId { get; set; }
    }
}
