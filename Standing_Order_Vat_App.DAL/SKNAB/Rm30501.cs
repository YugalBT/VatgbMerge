using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm30501
    {
        public decimal Ncomamnt { get; set; }
        public short Rmdtypal { get; set; }
        public short Comprcnt { get; set; }
        public string Docnumbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Comtrsrc { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public string Commcode { get; set; } = null!;
        public short Prctosal { get; set; }
        public decimal Slsamnt { get; set; }
        public decimal Comdlram { get; set; }
        public byte Posted { get; set; }
        public byte Commpaid { get; set; }
        public short Commdest { get; set; }
        public decimal Orcomamt { get; set; }
        public decimal Orslsamt { get; set; }
        public decimal Orncmamt { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
