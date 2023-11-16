using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa000002
    {
        public string Userid { get; set; } = null!;
        public short Patu { get; set; }
        public string PaDocumentNumber { get; set; } = null!;
        public int PalineItemSeq { get; set; }
        public short Status { get; set; }
        public int DexRowId { get; set; }
    }
}
