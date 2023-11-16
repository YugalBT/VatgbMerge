using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40010
    {
        public short ExtenderType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public short WindowNumber { get; set; }
        public short FieldNumber { get; set; }
        public short CalculatedFieldType { get; set; }
        public string Fieldnam { get; set; } = null!;
        public short Decplcur { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
