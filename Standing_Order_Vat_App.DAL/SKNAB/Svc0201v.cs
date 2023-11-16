using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc0201v
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public int Equipid { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Probcde { get; set; } = null!;
        public string Rprcode { get; set; } = null!;
        public string Causecde { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public string Custname { get; set; } = null!;
        public string Prdline { get; set; } = null!;
        public int? DexRowId { get; set; }
    }
}
