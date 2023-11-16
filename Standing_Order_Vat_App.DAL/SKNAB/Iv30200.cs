using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30200
    {
        public string Trxsorce { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public string Docnumbr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Srcrfrncnmbr { get; set; } = null!;
        public short Sourceindicator { get; set; }
        public int DexRowId { get; set; }
    }
}
