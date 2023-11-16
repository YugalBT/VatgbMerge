using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop30360
    {
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public int Actindx { get; set; }
        public byte Bkouttax { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Taxpurch { get; set; }
        public decimal Orgtxpch { get; set; }
        public decimal Totpurch { get; set; }
        public decimal Ortotpur { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Txdtottx { get; set; }
        public decimal Ottaxpon { get; set; }
        public string Trxsorce { get; set; } = null!;
        public decimal PopTaxNoteIdArray1 { get; set; }
        public decimal PopTaxNoteIdArray2 { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
