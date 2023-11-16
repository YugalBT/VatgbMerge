using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10705
    {
        public string Pavidn { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int Actindx { get; set; }
        public short Disttype { get; set; }
        public decimal Xchgrate { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public int DexRowId { get; set; }
    }
}
