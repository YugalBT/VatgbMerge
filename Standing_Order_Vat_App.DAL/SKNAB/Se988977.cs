using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Se988977
    {
        public string Seoptnme { get; set; } = null!;
        public short SeColumnNumber { get; set; }
        public string Secol { get; set; } = null!;
        public short Secoltyp { get; set; }
        public string Budgetid { get; set; } = null!;
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
