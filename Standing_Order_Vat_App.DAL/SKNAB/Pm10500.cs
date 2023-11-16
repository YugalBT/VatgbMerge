using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm10500
    {
        public string Vendorid { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public short Doctype { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Taxdtlid { get; set; } = null!;
        public byte Bkouttax { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Pctaxamt { get; set; }
        public decimal Orpurtax { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public int Actindx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public decimal Tdttxpur { get; set; }
        public decimal Ortxbpur { get; set; }
        public decimal Txdttpur { get; set; }
        public decimal Ortotpur { get; set; }
        public short Currnidx { get; set; }
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
