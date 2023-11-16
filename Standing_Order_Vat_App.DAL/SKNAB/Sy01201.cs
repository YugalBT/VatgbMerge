using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy01201
    {
        public short Customlinkprmpt { get; set; }
        public string Customlinklbl { get; set; } = null!;
        public string Customlinkfieldval { get; set; } = null!;
        public string Customlinkinetaddr { get; set; } = null!;
        public short Customlinkaddrtype { get; set; }
        public short Customlinkaddrfield { get; set; }
        public int DexRowId { get; set; }
    }
}
