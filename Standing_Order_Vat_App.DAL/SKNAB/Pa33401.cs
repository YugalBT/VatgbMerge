using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa33401
    {
        public short Pabilltrxt { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Padocnumber20 { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int Dstindx { get; set; }
        public decimal Padistam { get; set; }
        public decimal Paremamo { get; set; }
        public int DexRowId { get; set; }
    }
}
