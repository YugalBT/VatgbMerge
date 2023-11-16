using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop70100
    {
        public short Procorig { get; set; }
        public string Userid { get; set; } = null!;
        public string Ponumber { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string User2ent { get; set; } = null!;
        public short Postatus { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public byte Mktoproc { get; set; }
        public short Error { get; set; }
        public int DexRowId { get; set; }
    }
}
