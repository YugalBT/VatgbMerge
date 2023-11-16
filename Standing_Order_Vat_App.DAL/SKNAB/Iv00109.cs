using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00109
    {
        public string Itemnmbr { get; set; } = null!;
        public int Ord { get; set; }
        public short Snsegtype { get; set; }
        public short Datefmt { get; set; }
        public short Sgmntlth { get; set; }
        public short Snoperation { get; set; }
        public string Snstartval { get; set; } = null!;
        public string Snendval { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
