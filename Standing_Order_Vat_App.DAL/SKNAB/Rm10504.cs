using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm10504
    {
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public decimal Comdlram { get; set; }
        public decimal Ncomamnt { get; set; }
        public short Comprcnt { get; set; }
        public short Prctosal { get; set; }
        public decimal Slsamnt { get; set; }
        public string Comtrsrc { get; set; } = null!;
        public decimal Orcomamt { get; set; }
        public decimal Orncmamt { get; set; }
        public decimal Orslsamt { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
