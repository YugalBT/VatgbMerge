using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dta10100
    {
        public short Dtaseries { get; set; }
        public string Dtaref { get; set; } = null!;
        public int Actindx { get; set; }
        public int Seqnumbr { get; set; }
        public string Groupid { get; set; } = null!;
        public string DtaGlReference { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public decimal Groupamt { get; set; }
        public int Jrnentry { get; set; }
        public DateTime Trxdate { get; set; }
        public short Pstgstus { get; set; }
        public int DexRowId { get; set; }
    }
}
