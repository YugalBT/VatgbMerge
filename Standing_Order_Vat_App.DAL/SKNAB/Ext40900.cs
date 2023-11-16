using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40900
    {
        public string ImportId { get; set; } = null!;
        public string ImportDescription { get; set; } = null!;
        public short ImportType { get; set; }
        public short ImportFileType { get; set; }
        public string PtWindowId { get; set; } = null!;
        public short FieldNumber { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
