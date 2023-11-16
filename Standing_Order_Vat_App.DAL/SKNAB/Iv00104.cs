using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00104
    {
        public string Itemnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Cmptitnm { get; set; } = null!;
        public string Cmpituom { get; set; } = null!;
        public decimal Cmpitqty { get; set; }
        public byte Cmpsernm { get; set; }
        public int DexRowId { get; set; }
    }
}
