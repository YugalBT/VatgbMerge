using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gst00105
    {
        public string Pavidn { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Taxpurch { get; set; }
        public decimal Orgtxpch { get; set; }
        public decimal Totpurch { get; set; }
        public decimal Ortotpur { get; set; }
        public string Trxsorce { get; set; } = null!;
        public decimal PopTaxNoteIdArray1 { get; set; }
        public decimal PopTaxNoteIdArray2 { get; set; }
        public decimal Pctaxamt { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Txdttpur { get; set; }
        public decimal Tdttxpur { get; set; }
        public short Currnidx { get; set; }
        public byte Bkouttax { get; set; }
        public decimal Orpurtax { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Paotdtp { get; set; }
        public decimal Paotdtt { get; set; }
        public int DexRowId { get; set; }
    }
}
