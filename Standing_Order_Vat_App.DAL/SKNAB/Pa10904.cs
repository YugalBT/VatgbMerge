using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10904
    {
        public short PaivTransferType { get; set; }
        public string PaivDocumentNo { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public decimal Taxamnt { get; set; }
        public byte Bkouttax { get; set; }
        public decimal Pctaxamt { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Txdttpur { get; set; }
        public decimal Tdttxpur { get; set; }
        public int Actindx { get; set; }
        public int DexRowId { get; set; }
    }
}
