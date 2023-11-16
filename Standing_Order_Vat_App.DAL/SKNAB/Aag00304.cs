using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00304
    {
        public string Userid { get; set; } = null!;
        public string AaWorkbookName { get; set; } = null!;
        public short AaHdrIdcol { get; set; }
        public int DexRowId { get; set; }
    }
}
