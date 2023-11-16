using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl40300
    {
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public int Pstgnmbr { get; set; }
        public int DexRowId { get; set; }
    }
}
