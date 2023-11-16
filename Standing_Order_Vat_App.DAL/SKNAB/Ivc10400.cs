using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc10400
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public short Comprcnt { get; set; }
        public decimal Comdlram { get; set; }
        public decimal Ncomamnt { get; set; }
        public short Prctosal { get; set; }
        public decimal Slsamnt { get; set; }
        public string Commcode { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public short Commflag { get; set; }
        public short Actvtype { get; set; }
        public int DexRowId { get; set; }
    }
}
