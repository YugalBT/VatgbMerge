using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext43400
    {
        public string ExtenderLookupId { get; set; } = null!;
        public string ExtenderLookupDesc { get; set; } = null!;
        public short Prodid { get; set; }
        public string Tabltech { get; set; } = null!;
        public string Fieldnam { get; set; } = null!;
        public string FieldName2 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Formname { get; set; } = null!;
        public string Winname { get; set; } = null!;
        public string FieldName3 { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
