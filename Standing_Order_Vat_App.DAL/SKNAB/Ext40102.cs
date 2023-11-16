using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40102
    {
        public string PtWindowId { get; set; } = null!;
        public short FieldNumber { get; set; }
        public int Lnitmseq { get; set; }
        public string Longname { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
