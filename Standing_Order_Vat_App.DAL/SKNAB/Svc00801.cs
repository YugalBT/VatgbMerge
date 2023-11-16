using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00801
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Keyword { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
