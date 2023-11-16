using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40901
    {
        public string ImportId { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short FieldNumber { get; set; }
        public short StartPosition { get; set; }
        public short EndPosition { get; set; }
        public int DexRowId { get; set; }
    }
}
