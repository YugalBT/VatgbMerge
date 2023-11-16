using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40012
    {
        public short ExtenderType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public short WindowNumber { get; set; }
        public short FieldNumber { get; set; }
        public int Lnitmseq { get; set; }
        public string FieldAlias { get; set; } = null!;
        public short FieldOptionNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
