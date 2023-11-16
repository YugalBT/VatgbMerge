using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10212
    {
        public string Trxsourc { get; set; } = null!;
        public string Rprtname { get; set; } = null!;
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Expttype { get; set; }
        public string Filename { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
