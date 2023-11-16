using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class PalbInvc
    {
        public string Docnumbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Aptodcty { get; set; }
        public string Aptodcnm { get; set; } = null!;
        public decimal Apptoamt { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
