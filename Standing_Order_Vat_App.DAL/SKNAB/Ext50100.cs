using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext50100
    {
        public short UserOrClass { get; set; }
        public string Userid { get; set; } = null!;
        public short SecurityType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public byte Acesible { get; set; }
        public int DexRowId { get; set; }
    }
}
