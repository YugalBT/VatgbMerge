using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30201
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public int Equipid { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Prdline { get; set; } = null!;
        public string Probcde { get; set; } = null!;
        public string Causecde { get; set; } = null!;
        public string Rprcode { get; set; } = null!;
        public decimal NoteIndex1 { get; set; }
        public decimal NoteIndex2 { get; set; }
        public decimal NoteIndex3 { get; set; }
        public int DexRowId { get; set; }
    }
}
