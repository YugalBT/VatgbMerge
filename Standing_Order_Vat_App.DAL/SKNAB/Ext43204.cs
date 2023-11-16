using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext43204
    {
        public short ExtenderType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public short WindowNumber { get; set; }
        public int Lnitmseq { get; set; }
        public string NoteTypeDescription { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
