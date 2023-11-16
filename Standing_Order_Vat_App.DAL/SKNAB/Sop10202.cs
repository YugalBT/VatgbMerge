using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10202
    {
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public int Cmpntseq { get; set; }
        public int Lnitmseq { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Comment1 { get; set; } = null!;
        public string Comment2 { get; set; } = null!;
        public string Comment3 { get; set; } = null!;
        public string Comment4 { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Cmmttext { get; set; } = null!;
    }
}
