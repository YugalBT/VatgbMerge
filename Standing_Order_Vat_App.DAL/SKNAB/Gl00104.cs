using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl00104
    {
        public int Actindx { get; set; }
        public byte Sepratr1 { get; set; }
        public int Dstindx { get; set; }
        public byte Sepratr2 { get; set; }
        public int Bdnindx { get; set; }
        public int DexRowId { get; set; }
    }
}
