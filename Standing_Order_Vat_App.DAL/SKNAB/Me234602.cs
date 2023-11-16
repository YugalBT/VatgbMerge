using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me234602
    {
        public string Chekbkid { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string MeEftGenerationTimest { get; set; } = null!;
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public string Ormstrid { get; set; } = null!;
        public byte MeDummyFileConvertDe { get; set; }
        public int DexRowId { get; set; }
    }
}
