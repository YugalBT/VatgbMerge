using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10106
    {
        public short Rptngyr { get; set; }
        public string Employid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Loclcode { get; set; } = null!;
        public decimal Loclwges { get; set; }
        public decimal Lclintax { get; set; }
        public byte W2printd { get; set; }
        public short Taxtype { get; set; }
        public int DexRowId { get; set; }
    }
}
