using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00700
    {
        public short AaOption { get; set; }
        public string AaMultiLangStr { get; set; } = null!;
        public byte AaIsOptionSet { get; set; }
        public int DexRowId { get; set; }
    }
}
