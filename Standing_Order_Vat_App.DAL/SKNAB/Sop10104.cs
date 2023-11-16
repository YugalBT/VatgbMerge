using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10104
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public string Prchldid { get; set; } = null!;
        public byte Delete1 { get; set; }
        public string Userid { get; set; } = null!;
        public DateTime Holddate { get; set; }
        public DateTime Time1 { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
