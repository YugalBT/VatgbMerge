using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00914
    {
        public int Lnitmseq { get; set; }
        public string Aplicfil { get; set; } = null!;
        public byte Mandatory { get; set; }
        public string Dtapthnm { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
