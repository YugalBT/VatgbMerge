using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm80800
    {
        public string Trxsorce { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public short Doctype { get; set; }
        public string Campynbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public string Chamcbid { get; set; } = null!;
        public decimal Chekamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
