using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40011
    {
        public short ExtenderType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public short WindowNumber { get; set; }
        public short FieldNumber { get; set; }
        public int Lnitmseq { get; set; }
        public string FieldAlias { get; set; } = null!;
        public short FieldWindowNumber { get; set; }
        public short FieldFieldNumber { get; set; }
        public short FieldExtraNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
