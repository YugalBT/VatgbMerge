using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm80900
    {
        public string Userid { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public string Id { get; set; } = null!;
        public short Doctype { get; set; }
        public string Curncyid { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public short Index1 { get; set; }
        public int DexRowId { get; set; }
    }
}
