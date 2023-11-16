using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop50300
    {
        public string Userid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public short Doctype { get; set; }
        public string Locncode { get; set; } = null!;
        public int Docprintseq { get; set; }
        public int Cmpntseq { get; set; }
        public int Lnitmseq { get; set; }
        public int DexRowId { get; set; }
    }
}
