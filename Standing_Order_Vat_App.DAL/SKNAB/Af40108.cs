using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40108
    {
        public short Reportid { get; set; }
        public short Totrwnum { get; set; }
        public short Mbrwnum { get; set; }
        public int DexRowId { get; set; }
    }
}
