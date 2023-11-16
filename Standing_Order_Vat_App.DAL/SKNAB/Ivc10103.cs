using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc10103
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Comment1 { get; set; } = null!;
        public string Comment2 { get; set; } = null!;
        public string Comment3 { get; set; } = null!;
        public string Comment4 { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Cmmttext { get; set; } = null!;
    }
}
