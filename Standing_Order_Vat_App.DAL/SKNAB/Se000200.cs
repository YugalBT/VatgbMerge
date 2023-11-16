using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Se000200
    {
        public short Sgmtnumb { get; set; }
        public string Sgmntid { get; set; } = null!;
        public int Actindx { get; set; }
        public int DexRowId { get; set; }
    }
}
