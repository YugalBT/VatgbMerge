using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40201
    {
        public string ShortcutId { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short MacroFieldType { get; set; }
        public string Fieldnam { get; set; } = null!;
        public decimal Total { get; set; }
        public string Strga255 { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
