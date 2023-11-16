using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40601
    {
        public string WarningId { get; set; } = null!;
        public short Prodid { get; set; }
        public string Formname { get; set; } = null!;
        public string Winname { get; set; } = null!;
        public string Fieldnam { get; set; } = null!;
        public short FieldTriggerMethod { get; set; }
        public int DexRowId { get; set; }
    }
}
