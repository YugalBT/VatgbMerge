using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40107
    {
        public short Reportid { get; set; }
        public short Totrwnum { get; set; }
        public short Tknodnum { get; set; }
        public short Strownum { get; set; }
        public short Endrwnum { get; set; }
        public int DexRowId { get; set; }
    }
}
