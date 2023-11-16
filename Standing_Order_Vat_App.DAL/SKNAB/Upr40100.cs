using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40100
    {
        public string Futasuta { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Epridnbr { get; set; } = null!;
        public string Estidnbr { get; set; } = null!;
        public int Fusutxrt { get; set; }
        public decimal Fusuwlmt { get; set; }
        public byte Intxshan { get; set; }
        public byte Inprstwg { get; set; }
        public decimal Noteindx { get; set; }
        public string StatTaxId { get; set; } = null!;
        public string Txentycd { get; set; } = null!;
        public string Othstdat { get; set; } = null!;
        public string Stcntrlnum { get; set; } = null!;
        public string Suppdat1 { get; set; } = null!;
        public string Suppdat2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
