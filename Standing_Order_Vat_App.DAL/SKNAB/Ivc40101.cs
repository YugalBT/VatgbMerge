using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc40101
    {
        public short Doctype { get; set; }
        public string Doctyabr { get; set; } = null!;
        public string Doctynam { get; set; } = null!;
        public string Invcnmbr { get; set; } = null!;
        public short Setupkey { get; set; }
        public int DexRowId { get; set; }
    }
}
