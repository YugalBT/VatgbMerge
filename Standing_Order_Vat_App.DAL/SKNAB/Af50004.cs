using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af50004
    {
        public string Userid { get; set; } = null!;
        public int Actindx { get; set; }
        public string Actnumst { get; set; } = null!;
        public short Reportid { get; set; }
        public short Prcssqnc { get; set; }
        public int DexRowId { get; set; }
    }
}
