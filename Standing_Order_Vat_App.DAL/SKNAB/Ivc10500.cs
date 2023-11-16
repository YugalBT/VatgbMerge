using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc10500
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public int Actindx { get; set; }
        public byte Bkouttax { get; set; }
        public byte Txabletx { get; set; }
        public decimal Staxamnt { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Taxdtsls { get; set; }
        public decimal Tdttxsls { get; set; }
        public decimal Txdtottx { get; set; }
        public byte Delete1 { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
