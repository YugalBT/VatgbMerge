using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm00101
    {
        public string Vndclsid { get; set; } = null!;
        public short Disttype { get; set; }
        public int Seqnumbr { get; set; }
        public int Actindx { get; set; }
        public byte DefaultOnTrx { get; set; }
        public int DexRowId { get; set; }
    }
}
