using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10101
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public short Comprcnt { get; set; }
        public decimal Commamnt { get; set; }
        public decimal Ocommamt { get; set; }
        public decimal Ncomamnt { get; set; }
        public decimal Orncmamt { get; set; }
        public short Prctosal { get; set; }
        public decimal Actslamt { get; set; }
        public decimal Orslsamt { get; set; }
        public decimal Cmmslamt { get; set; }
        public decimal Orcosamt { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
