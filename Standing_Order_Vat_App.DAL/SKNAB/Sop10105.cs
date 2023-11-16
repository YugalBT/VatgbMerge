using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10105
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public int Actindx { get; set; }
        public byte Bkouttax { get; set; }
        public byte Txabletx { get; set; }
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
        public decimal Txdtottx { get; set; }
        public decimal Ottaxpon { get; set; }
        public byte Delete1 { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
