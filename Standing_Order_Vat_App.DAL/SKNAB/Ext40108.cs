using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40108
    {
        public string PtWindowId { get; set; } = null!;
        public string Fieldnam { get; set; } = null!;
        public string FieldName2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
