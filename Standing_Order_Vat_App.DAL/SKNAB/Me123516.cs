using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me123516
    {
        public string OutputFormat { get; set; } = null!;
        public short MeLinePosition { get; set; }
        public short MeFieldPosition { get; set; }
        public string MeFieldName { get; set; } = null!;
        public short MeFieldType { get; set; }
        public short MeStandardFields { get; set; }
        public short FieldLength { get; set; }
        public string MeConstantValues { get; set; } = null!;
        public short MeFieldFormat { get; set; }
        public string MeFiller { get; set; } = null!;
        public short MeJustification { get; set; }
        public int DexRowId { get; set; }
    }
}
