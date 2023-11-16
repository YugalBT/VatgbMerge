using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp400004
    {
        public string Userid { get; set; } = null!;
        public string Filename { get; set; } = null!;
        public short PpErrorCheckLink { get; set; }
        public string PpDocumentNumber { get; set; } = null!;
        public string PpProfileName { get; set; } = null!;
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
