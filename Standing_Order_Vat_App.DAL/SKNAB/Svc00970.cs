using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00970
    {
        public string ShortName { get; set; } = null!;
        public string LongName { get; set; } = null!;
        public string Path { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
