using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40117
    {
        public string PtWindowId { get; set; } = null!;
        public short FieldNumber { get; set; }
        public short StringFormat { get; set; }
        public string StringMask { get; set; } = null!;
        public byte UseMask { get; set; }
        public short MaxCharacters { get; set; }
        public int DexRowId { get; set; }
    }
}
