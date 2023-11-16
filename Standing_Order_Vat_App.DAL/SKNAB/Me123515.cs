using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me123515
    {
        public string OutputFormat { get; set; } = null!;
        public short MeLinePosition { get; set; }
        public string Bankid { get; set; } = null!;
        public short MeLineType { get; set; }
        public string MeFileName { get; set; } = null!;
        public short MeOutputType { get; set; }
        public short MeNumberOfFields { get; set; }
        public short MeFileLength { get; set; }
        public int DexRowId { get; set; }
    }
}
