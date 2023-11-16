using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm10601
    {
        public string Bachnumb { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Taxdtlid { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public int Actindx { get; set; }
        public byte Bkouttax { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Staxamnt { get; set; }
        public decimal Orslstax { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Taxdtsls { get; set; }
        public decimal Ortotsls { get; set; }
        public decimal Tdttxsls { get; set; }
        public decimal Ortxsls { get; set; }
        public byte Posted { get; set; }
        public int Seqnumbr { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
