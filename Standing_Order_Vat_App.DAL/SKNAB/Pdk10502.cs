using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk10502
    {
        public short PdkEeTrxType { get; set; }
        public string PdkEeNo { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public byte Bkouttax { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Pareimburstaxamt { get; set; }
        public decimal Paorigreimtaxamt { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Pctaxamt { get; set; }
        public decimal Orpurtax { get; set; }
        public decimal Txdttpur { get; set; }
        public decimal Ortotpur { get; set; }
        public decimal Tdttxpur { get; set; }
        public decimal Ortxbpur { get; set; }
        public int Actindx { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
