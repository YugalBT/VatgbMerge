using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy05500
    {
        public string Tblphysnm { get; set; } = null!;
        public string Doccode { get; set; } = null!;
        public string Prodtcod { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
